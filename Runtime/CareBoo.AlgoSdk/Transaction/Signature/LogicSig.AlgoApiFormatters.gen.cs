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
    
    
    public partial struct LogicSig
    {
        
        private static bool @__generated__IsValid = LogicSig.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.LogicSig>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.LogicSig>(false).Assign("l", (AlgoSdk.LogicSig x) => x.Program, (ref AlgoSdk.LogicSig x, System.Byte[] value) => x.Program = value, AlgoSdk.ArrayComparer<System.Byte>.Instance).Assign("arg", (AlgoSdk.LogicSig x) => x.Args, (ref AlgoSdk.LogicSig x, Unity.Collections.FixedList128Bytes<System.Byte>[] value) => x.Args = value, AlgoSdk.ArrayComparer<Unity.Collections.FixedList128Bytes<System.Byte>>.Instance).Assign("sig", (AlgoSdk.LogicSig x) => x.Sig, (ref AlgoSdk.LogicSig x, AlgoSdk.Sig value) => x.Sig = value).Assign("msig", (AlgoSdk.LogicSig x) => x.Multisig, (ref AlgoSdk.LogicSig x, AlgoSdk.Multisig value) => x.Multisig = value));
            return true;
        }
    }
}
