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
    
    
    public partial struct SignProgramResponse
    {
        
        private static bool @__generated__IsValid = SignProgramResponse.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.SignProgramResponse>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.SignProgramResponse>(false).Assign("sig", (AlgoSdk.SignProgramResponse x) => x.SignedProgram, (ref AlgoSdk.SignProgramResponse x, AlgoSdk.Sig value) => x.SignedProgram = value).Assign("error", (AlgoSdk.SignProgramResponse x) => x.Error, (ref AlgoSdk.SignProgramResponse x, AlgoSdk.Optional<System.Boolean> value) => x.Error = value).Assign("message", (AlgoSdk.SignProgramResponse x) => x.Message, (ref AlgoSdk.SignProgramResponse x, System.String value) => x.Message = value, AlgoSdk.StringComparer.Instance));
            return true;
        }
    }
}
