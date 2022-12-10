using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Threading;
using Cysharp.Threading.Tasks;

namespace Algorand.Unity.WebSocket
{
    public class NativeWebSocketClient : IWebSocketClient
    {
        private static readonly object ConnectionLock = new object();

        private ClientWebSocket Connection;
        private readonly Uri uri;
        public Queue<WebSocketEvent> EventQueue { get; } = new Queue<WebSocketEvent>();

        public WebSocketState ReadyState => Connection?.State ?? WebSocketState.Closed;

        public NativeWebSocketClient(string url)
        {
            uri = new Uri(url);
            Connection = new ClientWebSocket();
        }

        public void Connect()
        {
            if (ReadyState == WebSocketState.Open)
            {
                throw new InvalidOperationException("Socket is already open");
            }

            if (ReadyState == WebSocketState.CloseSent)
            {
                throw new InvalidOperationException("Socket is closing");
            }

            try
            {
                ConnectAsync().Forget();
            }
            catch (Exception e)
            {
                throw new WebSocketException("Connection failed", e);
            }
        }

        private async UniTaskVoid ConnectAsync()
        {
            await Connection.ConnectAsync(uri, CancellationToken.None);
            OnOpen();
            var buffer = new byte[1024 * 4];
            try
            {
                while (true)
                {
                    var result = await Connection.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                    if (Connection.CloseStatus.HasValue)
                    {
                        OnClose();
                        break;
                    }
                    var payload = new byte[result.Count];
                    for (var i = 0; i < payload.Length; i++)
                    {
                        payload[i] = buffer[i];
                    }

                    OnMessage(payload);
                }
            }
            catch (Exception e)
            {
                OnError(e.Message);
            }
        }

        public void Close(WebSocketCloseStatus code = WebSocketCloseStatus.NormalClosure, string reason = null)
        {
            if (ReadyState == WebSocketState.CloseSent)
            {
                throw new InvalidOperationException("Socket is already closing");
            }

            if (ReadyState == WebSocketState.Closed)
            {
                throw new InvalidOperationException("Socket is already closed");
            }

            CloseAsync(code, reason).Forget();
        }

        private async UniTaskVoid CloseAsync(WebSocketCloseStatus code, string reason)
        {
            try
            {
                await Connection.CloseAsync(code, reason, default);
            }
            catch (Exception e)
            {
                OnError(e.Message);
            }
        }

        public void Send(ArraySegment<byte> data)
        {
            if (ReadyState != WebSocketState.Open)
            {
                throw new WebSocketException("Socket is not open");
            }

            SendAsync(data).Forget();
        }

        private async UniTaskVoid SendAsync(ArraySegment<byte> data)
        {
            try
            {
                await Connection.SendAsync(data, WebSocketMessageType.Binary, true, CancellationToken.None);
            }
            catch (Exception e)
            {
                OnError(e.Message);
            }
        }

        public WebSocketEvent Poll()
        {
            lock (ConnectionLock)
            {
                return EventQueue.Count > 0
                    ? EventQueue.Dequeue()
                    : new WebSocketEvent
                    {
                        ClientId = 0,
                        Payload = null,
                        Type = WebSocketEvent.WebSocketEventType.Nothing,
                        Error = null,
                        Reason = null
                    };
            }
        }

        private void OnOpen()
        {
            lock (ConnectionLock)
            {
                EventQueue.Enqueue(new WebSocketEvent
                {
                    ClientId = 0,
                    Payload = null,
                    Type = WebSocketEvent.WebSocketEventType.Open,
                    Error = null,
                    Reason = null
                });
            }
        }

        private void OnClose()
        {
            lock (ConnectionLock)
            {
                EventQueue.Enqueue(new WebSocketEvent
                {
                    ClientId = 0,
                    Payload = null,
                    Type = WebSocketEvent.WebSocketEventType.Close,
                    Error = null,
                    Reason = Connection.CloseStatusDescription
                });
            }
        }

        private void OnError(string message)
        {
            lock (ConnectionLock)
            {
                EventQueue.Enqueue(new WebSocketEvent
                {
                    ClientId = 0,
                    Payload = null,
                    Type = WebSocketEvent.WebSocketEventType.Error,
                    Error = message,
                    Reason = null,
                });
            }
        }

        private void OnMessage(byte[] payload)
        {
            lock (ConnectionLock)
            {
                EventQueue.Enqueue(new WebSocketEvent
                {
                    ClientId = 0,
                    Payload = payload,
                    Type = WebSocketEvent.WebSocketEventType.Payload,
                    Error = null,
                    Reason = null,
                });
            }
        }
    }
}
