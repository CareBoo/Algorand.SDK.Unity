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
    
    
    public partial struct Version
    {
        
        private static bool @__generated__IsValid = Version.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.Version>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.Version>(false).Assign("build", (AlgoSdk.Version x) => x.Build, (ref AlgoSdk.Version x, AlgoSdk.BuildVersion value) => x.Build = value).Assign("genesis_hash_b64", (AlgoSdk.Version x) => x.GenesisHashBase64, (ref AlgoSdk.Version x, Unity.Collections.FixedString64Bytes value) => x.GenesisHashBase64 = value).Assign("genesis_id", (AlgoSdk.Version x) => x.GenesisId, (ref AlgoSdk.Version x, Unity.Collections.FixedString32Bytes value) => x.GenesisId = value).Assign("versions", (AlgoSdk.Version x) => x.Versions, (ref AlgoSdk.Version x, Unity.Collections.FixedString32Bytes[] value) => x.Versions = value, AlgoSdk.ArrayComparer<Unity.Collections.FixedString32Bytes>.Instance));
            return true;
        }
    }
}
