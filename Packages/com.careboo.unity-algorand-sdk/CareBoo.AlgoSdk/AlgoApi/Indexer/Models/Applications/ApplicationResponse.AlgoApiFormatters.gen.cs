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
    
    
    public partial struct ApplicationResponse
    {
        
        private static bool @__generated__IsValid = ApplicationResponse.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.AddFormatter(typeof(AlgoSdk.ApplicationResponse), new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.ApplicationResponse>().Assign("application", null, (AlgoSdk.ApplicationResponse x) => x.Application, (ref AlgoSdk.ApplicationResponse x, AlgoSdk.Application value) => x.Application = value, false).Assign("current-round", null, (AlgoSdk.ApplicationResponse x) => x.CurrentRound, (ref AlgoSdk.ApplicationResponse x, System.UInt64 value) => x.CurrentRound = value, false));
            AlgoSdk.AlgoApiFormatterLookup.AddFormatter(typeof(AlgoSdk.ApplicationResponse[]), AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.ApplicationResponse[]>.Instance);
            return true;
        }
    }
}
