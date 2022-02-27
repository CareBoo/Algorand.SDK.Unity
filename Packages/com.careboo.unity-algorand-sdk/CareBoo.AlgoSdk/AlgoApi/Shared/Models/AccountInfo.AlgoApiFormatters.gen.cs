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
    
    
    public partial struct AccountInfo
    {
        
        private static bool @__generated__IsValid = AccountInfo.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.AddFormatter(typeof(AlgoSdk.AccountInfo), new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.AccountInfo>().Assign("address", null, (AlgoSdk.AccountInfo x) => x.Address, (ref AlgoSdk.AccountInfo x, AlgoSdk.Address value) => x.Address = value, false).Assign("amount", null, (AlgoSdk.AccountInfo x) => x.Amount, (ref AlgoSdk.AccountInfo x, System.UInt64 value) => x.Amount = value, false).Assign("amount-without-pending-rewards", null, (AlgoSdk.AccountInfo x) => x.AmountWithoutPendingRewards, (ref AlgoSdk.AccountInfo x, System.UInt64 value) => x.AmountWithoutPendingRewards = value, false).Assign("apps-local-state", null, (AlgoSdk.AccountInfo x) => x.ApplicationsLocalState, (ref AlgoSdk.AccountInfo x, AlgoSdk.ApplicationLocalState[] value) => x.ApplicationsLocalState = value, AlgoSdk.ArrayComparer<AlgoSdk.ApplicationLocalState>.Instance, false).Assign("apps-total-extra-pages", null, (AlgoSdk.AccountInfo x) => x.ApplicationsTotalExtraPages, (ref AlgoSdk.AccountInfo x, System.UInt64 value) => x.ApplicationsTotalExtraPages = value, false).Assign("apps-total-schema", null, (AlgoSdk.AccountInfo x) => x.ApplicationsTotalSchema, (ref AlgoSdk.AccountInfo x, AlgoSdk.StateSchema value) => x.ApplicationsTotalSchema = value, false).Assign("assets", null, (AlgoSdk.AccountInfo x) => x.Assets, (ref AlgoSdk.AccountInfo x, AlgoSdk.AssetHolding[] value) => x.Assets = value, AlgoSdk.ArrayComparer<AlgoSdk.AssetHolding>.Instance, false).Assign("auth-addr", null, (AlgoSdk.AccountInfo x) => x.AuthAddress, (ref AlgoSdk.AccountInfo x, AlgoSdk.Address value) => x.AuthAddress = value, false).Assign("closed-at-round", null, (AlgoSdk.AccountInfo x) => x.ClosedAtRound, (ref AlgoSdk.AccountInfo x, System.UInt64 value) => x.ClosedAtRound = value, false).Assign("created-apps", null, (AlgoSdk.AccountInfo x) => x.CreatedApplications, (ref AlgoSdk.AccountInfo x, AlgoSdk.Application[] value) => x.CreatedApplications = value, AlgoSdk.ArrayComparer<AlgoSdk.Application>.Instance, false).Assign("created-assets", null, (AlgoSdk.AccountInfo x) => x.CreatedAssets, (ref AlgoSdk.AccountInfo x, AlgoSdk.Asset[] value) => x.CreatedAssets = value, AlgoSdk.ArrayComparer<AlgoSdk.Asset>.Instance, false).Assign("created-at-round", null, (AlgoSdk.AccountInfo x) => x.CreatedAtRound, (ref AlgoSdk.AccountInfo x, System.UInt64 value) => x.CreatedAtRound = value, false).Assign("deleted", null, (AlgoSdk.AccountInfo x) => x.Deleted, (ref AlgoSdk.AccountInfo x, AlgoSdk.Optional<System.Boolean> value) => x.Deleted = value, false).Assign("participation", null, (AlgoSdk.AccountInfo x) => x.Participation, (ref AlgoSdk.AccountInfo x, AlgoSdk.AccountParticipation value) => x.Participation = value, false).Assign("pending-rewards", null, (AlgoSdk.AccountInfo x) => x.PendingRewards, (ref AlgoSdk.AccountInfo x, System.UInt64 value) => x.PendingRewards = value, false).Assign("reward-base", null, (AlgoSdk.AccountInfo x) => x.RewardBase, (ref AlgoSdk.AccountInfo x, System.UInt64 value) => x.RewardBase = value, false).Assign("rewards", null, (AlgoSdk.AccountInfo x) => x.Rewards, (ref AlgoSdk.AccountInfo x, System.UInt64 value) => x.Rewards = value, false).Assign("round", null, (AlgoSdk.AccountInfo x) => x.Round, (ref AlgoSdk.AccountInfo x, System.UInt64 value) => x.Round = value, false).Assign("sig-type", null, (AlgoSdk.AccountInfo x) => x.SignatureType, (ref AlgoSdk.AccountInfo x, AlgoSdk.SignatureType value) => x.SignatureType = value, AlgoSdk.ByteEnumComparer<AlgoSdk.SignatureType>.Instance, false).Assign("status", null, (AlgoSdk.AccountInfo x) => x.Status, (ref AlgoSdk.AccountInfo x, Unity.Collections.FixedString32Bytes value) => x.Status = value, false));
            AlgoSdk.AlgoApiFormatterLookup.AddFormatter(typeof(AlgoSdk.SignatureType), new AlgoSdk.Formatters.SignatureTypeFormatter());
            AlgoSdk.AlgoApiFormatterLookup.AddFormatter(typeof(AlgoSdk.SignatureType[]), AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.SignatureType[]>.Instance);
            AlgoSdk.AlgoApiFormatterLookup.AddFormatter(typeof(AlgoSdk.AccountInfo[]), AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.AccountInfo[]>.Instance);
            return true;
        }
    }
}
