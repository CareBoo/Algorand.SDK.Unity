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


    public partial struct SignMultisigResponse
    {

        private static bool @__generated__IsValid = SignMultisigResponse.@__generated__InitializeAlgoApiFormatters();

        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.SignMultisigResponse>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.SignMultisigResponse>().Assign("multisig", null, (AlgoSdk.SignMultisigResponse x) => x.SignedTransaction, (ref AlgoSdk.SignMultisigResponse x, System.Byte[] value) => x.SignedTransaction = value, AlgoSdk.ArrayComparer<byte>.Instance, false).Assign("error", null, (AlgoSdk.SignMultisigResponse x) => x.Error, (ref AlgoSdk.SignMultisigResponse x, AlgoSdk.Optional<System.Boolean> value) => x.Error = value, false).Assign("message", null, (AlgoSdk.SignMultisigResponse x) => x.Message, (ref AlgoSdk.SignMultisigResponse x, System.String value) => x.Message = value, AlgoSdk.StringComparer.Instance, false));
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.SignMultisigResponse[]>(AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.SignMultisigResponse>.Instance);
            return true;
        }
    }
}
