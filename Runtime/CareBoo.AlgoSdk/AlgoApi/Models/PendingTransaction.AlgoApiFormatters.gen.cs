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
    
    
    public partial struct PendingTransaction
    {
        
        private static bool @__generated__IsValid = PendingTransaction.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.PendingTransaction>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.PendingTransaction>().Assign("application-index", "application-index", (AlgoSdk.PendingTransaction x) => x.ApplicationIndex, (ref AlgoSdk.PendingTransaction x, System.UInt64 value) => x.ApplicationIndex = value, false).Assign("asset-closing-amount", "asset-closing-amount", (AlgoSdk.PendingTransaction x) => x.AssetClosingAmount, (ref AlgoSdk.PendingTransaction x, System.UInt64 value) => x.AssetClosingAmount = value, false).Assign("asset-index", "asset-index", (AlgoSdk.PendingTransaction x) => x.AssetIndex, (ref AlgoSdk.PendingTransaction x, System.UInt64 value) => x.AssetIndex = value, false).Assign("close-rewards", "close-rewards", (AlgoSdk.PendingTransaction x) => x.CloseRewards, (ref AlgoSdk.PendingTransaction x, System.UInt64 value) => x.CloseRewards = value, false).Assign("closing-amount", "closing-amount", (AlgoSdk.PendingTransaction x) => x.ClosingAmount, (ref AlgoSdk.PendingTransaction x, System.UInt64 value) => x.ClosingAmount = value, false).Assign("confirmed-round", "confirmed-round", (AlgoSdk.PendingTransaction x) => x.ConfirmedRound, (ref AlgoSdk.PendingTransaction x, System.UInt64 value) => x.ConfirmedRound = value, false).Assign("global-state-delta", "global-state-delta", (AlgoSdk.PendingTransaction x) => x.GlobalStateDelta, (ref AlgoSdk.PendingTransaction x, AlgoSdk.EvalDeltaKeyValue[] value) => x.GlobalStateDelta = value, AlgoSdk.ArrayComparer<AlgoSdk.EvalDeltaKeyValue>.Instance, false).Assign("inner-txns", "inner-txns", (AlgoSdk.PendingTransaction x) => x.InnerTransactions, (ref AlgoSdk.PendingTransaction x, AlgoSdk.PendingTransaction[] value) => x.InnerTransactions = value, AlgoSdk.ArrayComparer<AlgoSdk.PendingTransaction>.Instance, false).Assign("local-state-delta", "local-state-delta", (AlgoSdk.PendingTransaction x) => x.LocalStateDelta, (ref AlgoSdk.PendingTransaction x, AlgoSdk.AccountStateDelta[] value) => x.LocalStateDelta = value, AlgoSdk.ArrayComparer<AlgoSdk.AccountStateDelta>.Instance, false).Assign("logs", "logs", (AlgoSdk.PendingTransaction x) => x.Logs, (ref AlgoSdk.PendingTransaction x, System.String[] value) => x.Logs = value, AlgoSdk.ArrayComparer<string, AlgoSdk.StringComparer>.Instance, false).Assign("pool-error", "pool-error", (AlgoSdk.PendingTransaction x) => x.PoolError, (ref AlgoSdk.PendingTransaction x, Unity.Collections.FixedString128Bytes value) => x.PoolError = value, false).Assign("receiver-rewards", "receiver-rewards", (AlgoSdk.PendingTransaction x) => x.ReceiverRewards, (ref AlgoSdk.PendingTransaction x, System.UInt64 value) => x.ReceiverRewards = value, false).Assign("sender-rewards", "sender-rewards", (AlgoSdk.PendingTransaction x) => x.SenderRewards, (ref AlgoSdk.PendingTransaction x, System.UInt64 value) => x.SenderRewards = value, false).Assign("txn", "txn", (AlgoSdk.PendingTransaction x) => x.Transaction, (ref AlgoSdk.PendingTransaction x, AlgoSdk.SignedTransaction value) => x.Transaction = value, false));
            return true;
        }
    }
}
