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
    
    
    public partial struct AssetResponse
    {
        
        private static bool @__generated__IsValid = AssetResponse.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.AssetResponse>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.AssetResponse>(false).Assign("asset", (AlgoSdk.AssetResponse x) => x.Asset, (ref AlgoSdk.AssetResponse x, AlgoSdk.Asset value) => x.Asset = value).Assign("current-round", (AlgoSdk.AssetResponse x) => x.CurrentRound, (ref AlgoSdk.AssetResponse x, System.UInt64 value) => x.CurrentRound = value));
            return true;
        }
    }
}
