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


    public partial struct ErrorResponse
    {

        private static bool @__generated__IsValid = ErrorResponse.@__generated__InitializeAlgoApiFormatters();

        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.ErrorResponse>(new AlgoSdk.Formatters.ErrorResponseFormatter());
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.ErrorResponse[]>(AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.ErrorResponse>.Instance);
            return true;
        }
    }
}
