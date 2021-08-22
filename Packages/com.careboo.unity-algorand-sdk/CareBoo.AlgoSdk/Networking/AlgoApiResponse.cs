using Unity.Collections;
using Unity.Jobs;
using UnityEngine.Networking;

namespace AlgoSdk
{
    public enum ContentType : byte
    {
        None,
        Json,
        MessagePack
    }

    public struct AlgoApiResponse
        : INativeDisposable
    {
        NativeArray<byte> data;
        UnityWebRequest.Result status;
        long responseCode;
        ContentType contentType;

        public AlgoApiResponse(ref UnityWebRequest completedRequest)
        {
            var requestData = completedRequest.downloadHandler.data;
            data = requestData != null
                ? new NativeArray<byte>(requestData, Allocator.Persistent)
                : default;
            status = completedRequest.result;
            responseCode = completedRequest.responseCode;
            var contentTypeHeader = completedRequest.GetResponseHeader("Content-Type");
            contentType = GetContentType(contentTypeHeader) switch
            {
                "application/json" => ContentType.Json,
                "application/msgpack" => ContentType.MessagePack,
                _ => ContentType.None
            };
        }

        public NativeArray<byte>.ReadOnly Data => data.AsReadOnly();

        public long ResponseCode => responseCode;

        public UnityWebRequest.Result Status => status;

        public ContentType ContentType => contentType;

        public JobHandle Dispose(JobHandle inputDeps)
        {
            return data.IsCreated ? data.Dispose(inputDeps) : inputDeps;
        }

        public void Dispose()
        {
            if (data.IsCreated)
                data.Dispose();
        }

        private static string GetContentType(string fullType)
        {
            for (var i = 0; i < fullType.Length; i++)
                if (fullType[i] == ';')
                    return fullType.Substring(0, i + 1);
            return fullType;
        }
    }

    public struct AlgoApiResponse<T>
        : INativeDisposable
        where T : unmanaged
    {
        AlgoApiResponse rawResponse;
        ErrorResponse error;
        NativeReference<T> payload;

        public AlgoApiResponse(AlgoApiResponse response)
        {
            this.rawResponse = response;
            NativeArray<byte>.ReadOnly rawBytes = response.Data;
            error = response.Status switch
            {
                UnityWebRequest.Result.ProtocolError => AlgoApiSerializer.Deserialize<ErrorResponse>(rawBytes, response.ContentType),
                UnityWebRequest.Result.ConnectionError => new ErrorResponse("Could not connect", Allocator.Persistent),
                UnityWebRequest.Result.DataProcessingError => new ErrorResponse("Error processing data from server", Allocator.Persistent),
                _ => default
            };
            payload = response.Status switch
            {
                UnityWebRequest.Result.Success => new NativeReference<T>(
                    AlgoApiSerializer.Deserialize<T>(rawBytes, response.ContentType),
                    Allocator.Persistent),
                _ => default
            };
        }

        public JobHandle Dispose(JobHandle inputDeps)
        {
            return JobHandle.CombineDependencies(
                rawResponse.Dispose(inputDeps),
                error.Dispose(inputDeps),
                payload.IsCreated ? payload.Dispose(inputDeps) : inputDeps
            );
        }

        public void Dispose()
        {
            rawResponse.Dispose();
            error.Dispose();
            if (payload.IsCreated) payload.Dispose();
        }

        public static implicit operator AlgoApiResponse<T>(AlgoApiResponse response)
        {
            return new AlgoApiResponse<T>(response);
        }

        public static implicit operator AlgoApiResponse(AlgoApiResponse<T> response)
        {
            response.error.Dispose();
            if (response.payload.IsCreated) response.payload.Dispose();
            return response.rawResponse;
        }
    }
}
