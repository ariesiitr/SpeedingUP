using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Thirdweb; // for interacting with the SDK
using System.Threading.Tasks; // for some async functionality

public class ConnectWallet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ConnectedState;
    public GameObject DisconnectedState;
    private ThirdwebSDK sdk;

    // Start is called before the first frame update
    void Start()
    {
        // Configure the network you deployed your contracts to:
        sdk = new ThirdwebSDK("goerli");
    }
    public async void ConnectsWallet()
    {
        // Connect to the wallet
        string address =
            await sdk
                .wallet
                .Connect(new WalletConnection()
                {
                    provider = WalletProvider.MetaMask,
                    chainId = 5 // Switch the wallet Goerli on connection
          });

        // Disable disconnected state
        DisconnectedState.SetActive(false);

        // Enable connected state
        ConnectedState.SetActive(true);

        // Set the ConnectedStates "Address" GameObjects text to the wallet address
        ConnectedState
          .transform
          .Find("Address")
          .GetComponent<TMPro.TextMeshProUGUI>()
          .text = address;
    }
}
