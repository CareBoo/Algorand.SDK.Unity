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
    
    
    public partial struct ListMultisigRequest
    {
        
        private static bool @__generated__IsValid = ListMultisigRequest.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.AddFormatter(typeof(AlgoSdk.ListMultisigRequest), new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.ListMultisigRequest>().Assign("wallet_handle_token", null, (AlgoSdk.ListMultisigRequest x) => x.WalletHandleToken, (ref AlgoSdk.ListMultisigRequest x, Unity.Collections.FixedString128Bytes value) => x.WalletHandleToken = value, false));
            AlgoSdk.AlgoApiFormatterLookup.AddFormatter(typeof(AlgoSdk.ListMultisigRequest[]), AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.ListMultisigRequest[]>.Instance);
            return true;
        }
    }
}
