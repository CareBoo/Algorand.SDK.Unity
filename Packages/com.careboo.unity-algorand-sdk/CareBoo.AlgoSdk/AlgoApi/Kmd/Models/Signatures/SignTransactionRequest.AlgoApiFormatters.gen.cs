//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlgoSdk
{


    public partial struct SignTransactionRequest
    {

        private static bool @__generated__IsValid = SignTransactionRequest.@__generated__InitializeAlgoApiFormatters();

        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.SignTransactionRequest>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.SignTransactionRequest>().Assign("public_key", null, (AlgoSdk.SignTransactionRequest x) => x.PublicKey, (ref AlgoSdk.SignTransactionRequest x, AlgoSdk.Crypto.Ed25519.PublicKey value) => x.PublicKey = value, false).Assign("transaction", null, (AlgoSdk.SignTransactionRequest x) => x.Transaction, (ref AlgoSdk.SignTransactionRequest x, System.Byte[] value) => x.Transaction = value, AlgoSdk.ArrayComparer<byte>.Instance, false).Assign("wallet_handle_token", null, (AlgoSdk.SignTransactionRequest x) => x.WalletHandleToken, (ref AlgoSdk.SignTransactionRequest x, Unity.Collections.FixedString128Bytes value) => x.WalletHandleToken = value, false).Assign("wallet_password", null, (AlgoSdk.SignTransactionRequest x) => x.WalletPassword, (ref AlgoSdk.SignTransactionRequest x, Unity.Collections.FixedString128Bytes value) => x.WalletPassword = value, false));
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.SignTransactionRequest[]>(AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.SignTransactionRequest>.Instance);
            return true;
        }
    }
}
