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
    
    
    public partial struct VersionsResponse
    {
        
        private static bool @__generated__IsValid = VersionsResponse.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.AddFormatter(typeof(AlgoSdk.VersionsResponse), new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.VersionsResponse>().Assign("versions", null, (AlgoSdk.VersionsResponse x) => x.Versions, (ref AlgoSdk.VersionsResponse x, Unity.Collections.FixedString64Bytes[] value) => x.Versions = value, AlgoSdk.ArrayComparer<Unity.Collections.FixedString64Bytes>.Instance, false));
            AlgoSdk.AlgoApiFormatterLookup.AddFormatter(typeof(AlgoSdk.VersionsResponse[]), AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.VersionsResponse[]>.Instance);
            return true;
        }
    }
}
