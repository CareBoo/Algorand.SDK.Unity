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


    public partial struct TealCompilationResult
    {

        private static bool @__generated__IsValid = TealCompilationResult.@__generated__InitializeAlgoApiFormatters();

        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.TealCompilationResult>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.TealCompilationResult>().Assign("hash", null, (AlgoSdk.TealCompilationResult x) => x.Hash, (ref AlgoSdk.TealCompilationResult x, System.String value) => x.Hash = value, AlgoSdk.StringComparer.Instance, false).Assign("result", null, (AlgoSdk.TealCompilationResult x) => x.CompiledBytesBase64, (ref AlgoSdk.TealCompilationResult x, System.String value) => x.CompiledBytesBase64 = value, AlgoSdk.StringComparer.Instance, false));
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.TealCompilationResult[]>(AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.TealCompilationResult>.Instance);
            return true;
        }
    }
}
