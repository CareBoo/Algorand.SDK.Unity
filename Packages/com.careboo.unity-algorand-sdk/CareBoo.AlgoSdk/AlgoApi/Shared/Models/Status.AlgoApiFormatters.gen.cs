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
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.Status>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.Status>().Assign("catchpoint", null, (AlgoSdk.Status x) => x.Catchpoint, (ref AlgoSdk.Status x, System.String value) => x.Catchpoint = value, AlgoSdk.StringComparer.Instance, false).Assign("catchpoint-acquired-blocks", null, (AlgoSdk.Status x) => x.CatchpointAcquiredBlocks, (ref AlgoSdk.Status x, System.UInt64 value) => x.CatchpointAcquiredBlocks = value, false).Assign("catchpoint-processed-accounts", null, (AlgoSdk.Status x) => x.CatchpointProcessedAmounts, (ref AlgoSdk.Status x, System.UInt64 value) => x.CatchpointProcessedAmounts = value, false).Assign("catchpoint-total-accounts", null, (AlgoSdk.Status x) => x.CatchpointTotalAccounts, (ref AlgoSdk.Status x, System.UInt64 value) => x.CatchpointTotalAccounts = value, false).Assign("catchpoint-total-blocks", null, (AlgoSdk.Status x) => x.CatchpointTotalBlocks, (ref AlgoSdk.Status x, System.UInt64 value) => x.CatchpointTotalBlocks = value, false).Assign("catchpoint-verified-accounts", null, (AlgoSdk.Status x) => x.CatchpointVerifiedAccounts, (ref AlgoSdk.Status x, System.UInt64 value) => x.CatchpointVerifiedAccounts = value, false).Assign("catchup-time", null, (AlgoSdk.Status x) => x.CatchupTime, (ref AlgoSdk.Status x, System.UInt64 value) => x.CatchupTime = value, false).Assign("last-catchpoint", null, (AlgoSdk.Status x) => x.LastCatchpoint, (ref AlgoSdk.Status x, System.String value) => x.LastCatchpoint = value, AlgoSdk.StringComparer.Instance, false).Assign("last-round", null, (AlgoSdk.Status x) => x.LastRound, (ref AlgoSdk.Status x, System.UInt64 value) => x.LastRound = value, false).Assign("last-version", null, (AlgoSdk.Status x) => x.LastVersion, (ref AlgoSdk.Status x, System.String value) => x.LastVersion = value, AlgoSdk.StringComparer.Instance, false).Assign("next-version", null, (AlgoSdk.Status x) => x.NextVersion, (ref AlgoSdk.Status x, System.String value) => x.NextVersion = value, AlgoSdk.StringComparer.Instance, false).Assign("next-version-round", null, (AlgoSdk.Status x) => x.NextVersionRound, (ref AlgoSdk.Status x, System.UInt64 value) => x.NextVersionRound = value, false).Assign("next-version-supported", null, (AlgoSdk.Status x) => x.NextVersionSupported, (ref AlgoSdk.Status x, System.Boolean value) => x.NextVersionSupported = value, false).Assign("stopped-at-unsupported-round", null, (AlgoSdk.Status x) => x.StoppedAtUnsupportedRound, (ref AlgoSdk.Status x, System.Boolean value) => x.StoppedAtUnsupportedRound = value, false).Assign("time-since-last-round", null, (AlgoSdk.Status x) => x.TimeSinceLastRound, (ref AlgoSdk.Status x, System.UInt64 value) => x.TimeSinceLastRound = value, false));
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.Status[]>(AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.Status>.Instance);
            return true;
        }
    }
}
