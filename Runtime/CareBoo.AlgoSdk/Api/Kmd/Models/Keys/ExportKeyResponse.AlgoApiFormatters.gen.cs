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
    
    
    public partial struct ExportKeyResponse
    {
        
        private static bool @__generated__IsValid = ExportKeyResponse.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.ExportKeyResponse>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.ExportKeyResponse>(false).Assign("error", (AlgoSdk.ExportKeyResponse x) => x.Error, (ref AlgoSdk.ExportKeyResponse x, AlgoSdk.Optional<System.Boolean> value) => x.Error = value).Assign("message", (AlgoSdk.ExportKeyResponse x) => x.Message, (ref AlgoSdk.ExportKeyResponse x, System.String value) => x.Message = value, AlgoSdk.StringComparer.Instance).Assign("private_key", (AlgoSdk.ExportKeyResponse x) => x.PrivateKey, (ref AlgoSdk.ExportKeyResponse x, AlgoSdk.PrivateKey value) => x.PrivateKey = value));
            return true;
        }
    }
}
