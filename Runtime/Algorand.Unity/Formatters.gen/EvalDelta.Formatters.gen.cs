//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using UnityCollections = Unity.Collections;


namespace Algorand.Unity
{
    
    
    public partial struct EvalDelta<TTxn>
    {
        
        private static bool @__generated__IsValid = EvalDelta<TTxn>.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            Algorand.Unity.AlgoApiFormatterLookup.Add<Algorand.Unity.EvalDelta<TTxn>>(new Algorand.Unity.AlgoApiObjectFormatter<Algorand.Unity.EvalDelta<TTxn>>(false).Assign("gd", (Algorand.Unity.EvalDelta<TTxn> x) => x.GlobalDelta, (ref Algorand.Unity.EvalDelta<TTxn> x, Algorand.Unity.StateDelta value) => x.GlobalDelta = value).Assign("ld", (Algorand.Unity.EvalDelta<TTxn> x) => x.LocalDeltas, (ref Algorand.Unity.EvalDelta<TTxn> x, Algorand.Unity.StateDelta[] value) => x.LocalDeltas = value, Algorand.Unity.ArrayComparer<Algorand.Unity.StateDelta>.Instance).Assign("lg", (Algorand.Unity.EvalDelta<TTxn> x) => x.Logs, (ref Algorand.Unity.EvalDelta<TTxn> x, System.String[] value) => x.Logs = value, Algorand.Unity.ArrayComparer<System.String, Algorand.Unity.StringComparer>.Instance).Assign("itx", (Algorand.Unity.EvalDelta<TTxn> x) => x.InnerTxns, (ref Algorand.Unity.EvalDelta<TTxn> x, TTxn[] value) => x.InnerTxns = value, Algorand.Unity.ArrayComparer<TTxn>.Instance));
            return true;
        }
    }
}
