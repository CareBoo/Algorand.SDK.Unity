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


    public partial struct TealKeyValue
    {

        private static bool @__generated__IsValid = TealKeyValue.@__generated__InitializeAlgoApiFormatters();

        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.TealKeyValue>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.TealKeyValue>().Assign("key", "key", (AlgoSdk.TealKeyValue x) => x.Key, (ref AlgoSdk.TealKeyValue x, Unity.Collections.FixedString128Bytes value) => x.Key = value, false).Assign("value", "value", (AlgoSdk.TealKeyValue x) => x.Value, (ref AlgoSdk.TealKeyValue x, AlgoSdk.TealValue value) => x.Value = value, false));
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.TealKeyValue[]>(AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.TealKeyValue>.Instance);
            return true;
        }
    }
}
