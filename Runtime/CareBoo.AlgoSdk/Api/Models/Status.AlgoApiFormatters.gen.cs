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
    
    
    public partial struct Status
    {
        
        private static bool @__generated__IsValid = Status.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.Status>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.Status>(false).Assign("catchpoint", (AlgoSdk.Status x) => x.Catchpoint, (ref AlgoSdk.Status x, System.String value) => x.Catchpoint = value, AlgoSdk.StringComparer.Instance).Assign("catchpoint-acquired-blocks", (AlgoSdk.Status x) => x.CatchpointAcquiredBlocks, (ref AlgoSdk.Status x, System.UInt64 value) => x.CatchpointAcquiredBlocks = value).Assign("catchpoint-processed-accounts", (AlgoSdk.Status x) => x.CatchpointProcessedAmounts, (ref AlgoSdk.Status x, System.UInt64 value) => x.CatchpointProcessedAmounts = value).Assign("catchpoint-total-accounts", (AlgoSdk.Status x) => x.CatchpointTotalAccounts, (ref AlgoSdk.Status x, System.UInt64 value) => x.CatchpointTotalAccounts = value).Assign("catchpoint-total-blocks", (AlgoSdk.Status x) => x.CatchpointTotalBlocks, (ref AlgoSdk.Status x, System.UInt64 value) => x.CatchpointTotalBlocks = value).Assign("catchpoint-verified-accounts", (AlgoSdk.Status x) => x.CatchpointVerifiedAccounts, (ref AlgoSdk.Status x, System.UInt64 value) => x.CatchpointVerifiedAccounts = value).Assign("catchup-time", (AlgoSdk.Status x) => x.CatchupTime, (ref AlgoSdk.Status x, System.UInt64 value) => x.CatchupTime = value).Assign("last-catchpoint", (AlgoSdk.Status x) => x.LastCatchpoint, (ref AlgoSdk.Status x, System.String value) => x.LastCatchpoint = value, AlgoSdk.StringComparer.Instance).Assign("last-round", (AlgoSdk.Status x) => x.LastRound, (ref AlgoSdk.Status x, System.UInt64 value) => x.LastRound = value).Assign("last-version", (AlgoSdk.Status x) => x.LastVersion, (ref AlgoSdk.Status x, System.String value) => x.LastVersion = value, AlgoSdk.StringComparer.Instance).Assign("next-version", (AlgoSdk.Status x) => x.NextVersion, (ref AlgoSdk.Status x, System.String value) => x.NextVersion = value, AlgoSdk.StringComparer.Instance).Assign("next-version-round", (AlgoSdk.Status x) => x.NextVersionRound, (ref AlgoSdk.Status x, System.UInt64 value) => x.NextVersionRound = value).Assign("next-version-supported", (AlgoSdk.Status x) => x.NextVersionSupported, (ref AlgoSdk.Status x, System.Boolean value) => x.NextVersionSupported = value).Assign("stopped-at-unsupported-round", (AlgoSdk.Status x) => x.StoppedAtUnsupportedRound, (ref AlgoSdk.Status x, System.Boolean value) => x.StoppedAtUnsupportedRound = value).Assign("time-since-last-round", (AlgoSdk.Status x) => x.TimeSinceLastRound, (ref AlgoSdk.Status x, System.UInt64 value) => x.TimeSinceLastRound = value));
            return true;
        }
    }
}
