//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlgoSdk.WalletConnect
{


    public partial struct JsonRpcRequest
    {

        private static bool @__generated__IsValid = JsonRpcRequest.@__generated__InitializeAlgoApiFormatters();

        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.WalletConnect.JsonRpcRequest>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.WalletConnect.JsonRpcRequest>().Assign("id", null, (AlgoSdk.WalletConnect.JsonRpcRequest x) => x.Id, (ref AlgoSdk.WalletConnect.JsonRpcRequest x, System.UInt64 value) => x.Id = value, false).Assign("jsonrpc", null, (AlgoSdk.WalletConnect.JsonRpcRequest x) => x.JsonRpc, (ref AlgoSdk.WalletConnect.JsonRpcRequest x, System.String value) => x.JsonRpc = value, AlgoSdk.StringComparer.Instance, false).Assign("method", null, (AlgoSdk.WalletConnect.JsonRpcRequest x) => x.Method, (ref AlgoSdk.WalletConnect.JsonRpcRequest x, System.String value) => x.Method = value, AlgoSdk.StringComparer.Instance, false).Assign("params", null, (AlgoSdk.WalletConnect.JsonRpcRequest x) => x.Params, (ref AlgoSdk.WalletConnect.JsonRpcRequest x, AlgoSdk.AlgoApiObject[] value) => x.Params = value, AlgoSdk.ArrayComparer<AlgoSdk.AlgoApiObject>.Instance, false));
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.WalletConnect.JsonRpcRequest[]>(AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.WalletConnect.JsonRpcRequest>.Instance);
            return true;
        }
    }
}
