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
    
    
    public partial struct DryrunSource
    {
        
        private static bool @__generated__IsValid = DryrunSource.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.AddFormatter(typeof(AlgoSdk.DryrunSource), new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.DryrunSource>().Assign("app-index", null, (AlgoSdk.DryrunSource x) => x.AppIndex, (ref AlgoSdk.DryrunSource x, System.UInt64 value) => x.AppIndex = value, false).Assign("field-name", null, (AlgoSdk.DryrunSource x) => x.FieldName, (ref AlgoSdk.DryrunSource x, Unity.Collections.FixedString32Bytes value) => x.FieldName = value, false).Assign("source", null, (AlgoSdk.DryrunSource x) => x.Source, (ref AlgoSdk.DryrunSource x, System.String value) => x.Source = value, AlgoSdk.StringComparer.Instance, false).Assign("txn-index", null, (AlgoSdk.DryrunSource x) => x.TransactionIndex, (ref AlgoSdk.DryrunSource x, System.UInt64 value) => x.TransactionIndex = value, false));
            AlgoSdk.AlgoApiFormatterLookup.AddFormatter(typeof(AlgoSdk.DryrunSource[]), AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.DryrunSource[]>.Instance);
            return true;
        }
    }
}
