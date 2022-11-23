using System.Collections;
using System.Collections.Generic;
using Algorand.Unity.WalletConnect;
using UnityEngine;
using UnityEngine.UI;

public class WalletConnectCanvas : MonoBehaviour
{
    public Text connectionStatus, transactionStatus, connectedAccount, amount, connectingTOWallet;

    public Image qrCodeDisplay;

    public GameObject requestingConnectionDisplay, connectedDisplay, notConnectedDisplay;

    public Button sendTestTransactionButton;

    public void setCanvasDisplay(SessionStatus status)
    {
        string currentStatus = "UNKNOWN";

        requestingConnectionDisplay.SetActive(false);
        connectedDisplay.SetActive(false);
        notConnectedDisplay.SetActive(false);

        switch (status)
        {
            case (SessionStatus.RequestingWalletConnection):
                requestingConnectionDisplay.SetActive(true);
                currentStatus = "Requesting Connection";
                break;
            case (SessionStatus.WalletConnected):
                connectedDisplay.SetActive(true);
                currentStatus = "Connected";
                break;
            case (SessionStatus.NoWalletConnected):
                notConnectedDisplay.SetActive(true);
                currentStatus = "Disconnected";
                break;
        }

        connectionStatus.text = $"Connection Status: {currentStatus}";
    }

    public void setConnectionStatus(string status)
    {
        connectionStatus.text = $"Connection Status: {status}";
    }

    public void setQRCode(Texture2D qrCode)
    {
        qrCodeDisplay.sprite = Sprite.Create(qrCode, new Rect(0, 0, qrCode.width, qrCode.height), Vector2.zero);
    }
}
