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
    
    
    public partial struct CreateWalletResponse
    {
        
        private static bool @__generated__IsValid = CreateWalletResponse.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.CreateWalletResponse>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.CreateWalletResponse>(false).Assign("error", (AlgoSdk.CreateWalletResponse x) => x.Error, (ref AlgoSdk.CreateWalletResponse x, AlgoSdk.Optional<System.Boolean> value) => x.Error = value).Assign("message", (AlgoSdk.CreateWalletResponse x) => x.Message, (ref AlgoSdk.CreateWalletResponse x, System.String value) => x.Message = value, AlgoSdk.StringComparer.Instance).Assign("wallet", (AlgoSdk.CreateWalletResponse x) => x.Wallet, (ref AlgoSdk.CreateWalletResponse x, AlgoSdk.Wallet value) => x.Wallet = value));
            return true;
        }
    }
}
