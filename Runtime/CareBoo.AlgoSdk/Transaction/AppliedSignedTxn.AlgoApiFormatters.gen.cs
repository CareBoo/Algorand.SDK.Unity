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
    
    
    public partial struct AppliedSignedTxn
    {
        
        private static bool @__generated__IsValid = AppliedSignedTxn.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.AppliedSignedTxn>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.AppliedSignedTxn>(false).Assign("sig", (AlgoSdk.AppliedSignedTxn x) => x.Sig, (ref AlgoSdk.AppliedSignedTxn x, AlgoSdk.Sig value) => x.Sig = value).Assign("msig", (AlgoSdk.AppliedSignedTxn x) => x.Msig, (ref AlgoSdk.AppliedSignedTxn x, AlgoSdk.Multisig value) => x.Msig = value).Assign("lsig", (AlgoSdk.AppliedSignedTxn x) => x.Lsig, (ref AlgoSdk.AppliedSignedTxn x, AlgoSdk.LogicSig value) => x.Lsig = value).Assign("txn", (AlgoSdk.AppliedSignedTxn x) => x.Txn, (ref AlgoSdk.AppliedSignedTxn x, AlgoSdk.Transaction value) => x.Txn = value).Assign("sgnr", (AlgoSdk.AppliedSignedTxn x) => x.AuthAddr, (ref AlgoSdk.AppliedSignedTxn x, AlgoSdk.Address value) => x.AuthAddr = value).Assign("ca", (AlgoSdk.AppliedSignedTxn x) => x.ClosingAmount, (ref AlgoSdk.AppliedSignedTxn x, AlgoSdk.MicroAlgos value) => x.ClosingAmount = value).Assign("aca", (AlgoSdk.AppliedSignedTxn x) => x.AssetClosingAmount, (ref AlgoSdk.AppliedSignedTxn x, System.UInt64 value) => x.AssetClosingAmount = value).Assign("rs", (AlgoSdk.AppliedSignedTxn x) => x.SenderRewards, (ref AlgoSdk.AppliedSignedTxn x, AlgoSdk.MicroAlgos value) => x.SenderRewards = value).Assign("rr", (AlgoSdk.AppliedSignedTxn x) => x.ReceiverRewards, (ref AlgoSdk.AppliedSignedTxn x, AlgoSdk.MicroAlgos value) => x.ReceiverRewards = value).Assign("rc", (AlgoSdk.AppliedSignedTxn x) => x.CloseRewards, (ref AlgoSdk.AppliedSignedTxn x, AlgoSdk.MicroAlgos value) => x.CloseRewards = value).Assign("dt", (AlgoSdk.AppliedSignedTxn x) => x.EvalDelta, (ref AlgoSdk.AppliedSignedTxn x, AlgoSdk.AppEvalDelta<AlgoSdk.AppliedSignedTxn> value) => x.EvalDelta = value).Assign("caid", (AlgoSdk.AppliedSignedTxn x) => x.ConfigAsset, (ref AlgoSdk.AppliedSignedTxn x, AlgoSdk.AssetIndex value) => x.ConfigAsset = value).Assign("apid", (AlgoSdk.AppliedSignedTxn x) => x.ApplicationId, (ref AlgoSdk.AppliedSignedTxn x, AlgoSdk.AppIndex value) => x.ApplicationId = value));
            return true;
        }
    }
}
