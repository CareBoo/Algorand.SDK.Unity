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


    public partial struct PrivateKey
    {

        private static bool @__generated__IsValid = PrivateKey.@__generated__InitializeAlgoApiFormatters();

        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.PrivateKey>(new AlgoSdk.Formatters.PrivateKeyFormatter());
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.PrivateKey[]>(AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.PrivateKey>.Instance);
            return true;
        }
    }
}
