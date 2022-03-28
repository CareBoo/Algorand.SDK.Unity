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
    
    
    public partial struct Transaction
    {
        
        private static bool @__generated__IsValid = Transaction.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.Transaction>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.Transaction>(false).Assign("signature", (AlgoSdk.Transaction x) => x.Signature, (ref AlgoSdk.Transaction x, AlgoSdk.TransactionSignature value) => x.Signature = value).Assign("apid", (AlgoSdk.Transaction x) => x.ApplicationId, (ref AlgoSdk.Transaction x, AlgoSdk.AppIndex value) => x.ApplicationId = value).Assign("apan", (AlgoSdk.Transaction x) => x.OnComplete, (ref AlgoSdk.Transaction x, AlgoSdk.OnCompletion value) => x.OnComplete = value, AlgoSdk.ByteEnumComparer<AlgoSdk.OnCompletion>.Instance).Assign("apap", (AlgoSdk.Transaction x) => x.ApprovalProgram, (ref AlgoSdk.Transaction x, AlgoSdk.CompiledTeal value) => x.ApprovalProgram = value).Assign("apsu", (AlgoSdk.Transaction x) => x.ClearStateProgram, (ref AlgoSdk.Transaction x, AlgoSdk.CompiledTeal value) => x.ClearStateProgram = value).Assign("apaa", (AlgoSdk.Transaction x) => x.AppArguments, (ref AlgoSdk.Transaction x, AlgoSdk.CompiledTeal[] value) => x.AppArguments = value, AlgoSdk.ArrayComparer<AlgoSdk.CompiledTeal>.Instance).Assign("apat", (AlgoSdk.Transaction x) => x.Accounts, (ref AlgoSdk.Transaction x, AlgoSdk.Address[] value) => x.Accounts = value, AlgoSdk.ArrayComparer<AlgoSdk.Address>.Instance).Assign("apfa", (AlgoSdk.Transaction x) => x.ForeignApps, (ref AlgoSdk.Transaction x, System.UInt64[] value) => x.ForeignApps = value, AlgoSdk.ArrayComparer<System.UInt64>.Instance).Assign("apas", (AlgoSdk.Transaction x) => x.ForeignAssets, (ref AlgoSdk.Transaction x, System.UInt64[] value) => x.ForeignAssets = value, AlgoSdk.ArrayComparer<System.UInt64>.Instance).Assign("apgs", (AlgoSdk.Transaction x) => x.GlobalStateSchema, (ref AlgoSdk.Transaction x, AlgoSdk.StateSchema value) => x.GlobalStateSchema = value).Assign("apls", (AlgoSdk.Transaction x) => x.LocalStateSchema, (ref AlgoSdk.Transaction x, AlgoSdk.StateSchema value) => x.LocalStateSchema = value).Assign("apep", (AlgoSdk.Transaction x) => x.ExtraProgramPages, (ref AlgoSdk.Transaction x, System.UInt64 value) => x.ExtraProgramPages = value).Assign("caid", (AlgoSdk.Transaction x) => x.ConfigAsset, (ref AlgoSdk.Transaction x, AlgoSdk.AssetIndex value) => x.ConfigAsset = value).Assign("apar", (AlgoSdk.Transaction x) => x.AssetParams, (ref AlgoSdk.Transaction x, AlgoSdk.AssetParams value) => x.AssetParams = value).Assign("fadd", (AlgoSdk.Transaction x) => x.FreezeAccount, (ref AlgoSdk.Transaction x, AlgoSdk.Address value) => x.FreezeAccount = value).Assign("faid", (AlgoSdk.Transaction x) => x.FreezeAsset, (ref AlgoSdk.Transaction x, AlgoSdk.AssetIndex value) => x.FreezeAsset = value).Assign("afrz", (AlgoSdk.Transaction x) => x.AssetFrozen, (ref AlgoSdk.Transaction x, AlgoSdk.Optional<System.Boolean> value) => x.AssetFrozen = value).Assign("xaid", (AlgoSdk.Transaction x) => x.XferAsset, (ref AlgoSdk.Transaction x, AlgoSdk.AssetIndex value) => x.XferAsset = value).Assign("aamt", (AlgoSdk.Transaction x) => x.AssetAmount, (ref AlgoSdk.Transaction x, System.UInt64 value) => x.AssetAmount = value).Assign("asnd", (AlgoSdk.Transaction x) => x.AssetSender, (ref AlgoSdk.Transaction x, AlgoSdk.Address value) => x.AssetSender = value).Assign("arcv", (AlgoSdk.Transaction x) => x.AssetReceiver, (ref AlgoSdk.Transaction x, AlgoSdk.Address value) => x.AssetReceiver = value).Assign("aclose", (AlgoSdk.Transaction x) => x.AssetCloseTo, (ref AlgoSdk.Transaction x, AlgoSdk.Address value) => x.AssetCloseTo = value).Assign("votekey", (AlgoSdk.Transaction x) => x.VoteParticipationKey, (ref AlgoSdk.Transaction x, AlgoSdk.Crypto.Ed25519.PublicKey value) => x.VoteParticipationKey = value).Assign("selkey", (AlgoSdk.Transaction x) => x.SelectionParticipationKey, (ref AlgoSdk.Transaction x, AlgoSdk.VrfPubKey value) => x.SelectionParticipationKey = value).Assign("votefst", (AlgoSdk.Transaction x) => x.VoteFirst, (ref AlgoSdk.Transaction x, System.UInt64 value) => x.VoteFirst = value).Assign("votelst", (AlgoSdk.Transaction x) => x.VoteLast, (ref AlgoSdk.Transaction x, System.UInt64 value) => x.VoteLast = value).Assign("votekd", (AlgoSdk.Transaction x) => x.VoteKeyDilution, (ref AlgoSdk.Transaction x, System.UInt64 value) => x.VoteKeyDilution = value).Assign("nonpart", (AlgoSdk.Transaction x) => x.NonParticipation, (ref AlgoSdk.Transaction x, AlgoSdk.Optional<System.Boolean> value) => x.NonParticipation = value).Assign("rcv", (AlgoSdk.Transaction x) => x.Receiver, (ref AlgoSdk.Transaction x, AlgoSdk.Address value) => x.Receiver = value).Assign("amt", (AlgoSdk.Transaction x) => x.Amount, (ref AlgoSdk.Transaction x, AlgoSdk.MicroAlgos value) => x.Amount = value).Assign("close", (AlgoSdk.Transaction x) => x.CloseRemainderTo, (ref AlgoSdk.Transaction x, AlgoSdk.Address value) => x.CloseRemainderTo = value).Assign("payment-transaction", (AlgoSdk.Transaction x) => x.PaymentParams, (ref AlgoSdk.Transaction x, AlgoSdk.PaymentTxn.Params value) => x.PaymentParams = value).Assign("asset-config-transaction", (AlgoSdk.Transaction x) => x.AssetConfigParams, (ref AlgoSdk.Transaction x, AlgoSdk.AssetConfigTxn.Params value) => x.AssetConfigParams = value).Assign("asset-transfer-transaction", (AlgoSdk.Transaction x) => x.AssetTransferParams, (ref AlgoSdk.Transaction x, AlgoSdk.AssetTransferTxn.Params value) => x.AssetTransferParams = value).Assign("asset-freeze-transaction", (AlgoSdk.Transaction x) => x.AssetFreezeParams, (ref AlgoSdk.Transaction x, AlgoSdk.AssetFreezeTxn.Params value) => x.AssetFreezeParams = value).Assign("application-transaction", (AlgoSdk.Transaction x) => x.AppCallParams, (ref AlgoSdk.Transaction x, AlgoSdk.AppCallTxn.Params value) => x.AppCallParams = value).Assign("keyreg-transction", (AlgoSdk.Transaction x) => x.KeyRegParams, (ref AlgoSdk.Transaction x, AlgoSdk.KeyRegTxn.Params value) => x.KeyRegParams = value).Assign("fee", (AlgoSdk.Transaction x) => x.Fee, (ref AlgoSdk.Transaction x, AlgoSdk.MicroAlgos value) => x.Fee = value).Assign("fv", (AlgoSdk.Transaction x) => x.FirstValidRound, (ref AlgoSdk.Transaction x, System.UInt64 value) => x.FirstValidRound = value).Assign("gh", (AlgoSdk.Transaction x) => x.GenesisHash, (ref AlgoSdk.Transaction x, AlgoSdk.GenesisHash value) => x.GenesisHash = value).Assign("lv", (AlgoSdk.Transaction x) => x.LastValidRound, (ref AlgoSdk.Transaction x, System.UInt64 value) => x.LastValidRound = value).Assign("snd", (AlgoSdk.Transaction x) => x.Sender, (ref AlgoSdk.Transaction x, AlgoSdk.Address value) => x.Sender = value).Assign("type", (AlgoSdk.Transaction x) => x.TransactionType, (ref AlgoSdk.Transaction x, AlgoSdk.TransactionType value) => x.TransactionType = value, AlgoSdk.ByteEnumComparer<AlgoSdk.TransactionType>.Instance).Assign("gen", (AlgoSdk.Transaction x) => x.GenesisId, (ref AlgoSdk.Transaction x, Unity.Collections.FixedString32Bytes value) => x.GenesisId = value).Assign("grp", (AlgoSdk.Transaction x) => x.Group, (ref AlgoSdk.Transaction x, AlgoSdk.TransactionId value) => x.Group = value).Assign("lx", (AlgoSdk.Transaction x) => x.Lease, (ref AlgoSdk.Transaction x, AlgoSdk.TransactionId value) => x.Lease = value).Assign("group", (AlgoSdk.Transaction x) => x.GroupHash, (ref AlgoSdk.Transaction x, AlgoSdk.Crypto.Sha512_256_Hash value) => x.GroupHash = value).Assign("lease", (AlgoSdk.Transaction x) => x.LeaseHash, (ref AlgoSdk.Transaction x, AlgoSdk.Crypto.Sha512_256_Hash value) => x.LeaseHash = value).Assign("note", (AlgoSdk.Transaction x) => x.Note, (ref AlgoSdk.Transaction x, System.Byte[] value) => x.Note = value, AlgoSdk.ArrayComparer<System.Byte>.Instance).Assign("rekey", (AlgoSdk.Transaction x) => x.RekeyTo, (ref AlgoSdk.Transaction x, AlgoSdk.Address value) => x.RekeyTo = value).Assign("id", (AlgoSdk.Transaction x) => x.Id, (ref AlgoSdk.Transaction x, AlgoSdk.TransactionId value) => x.Id = value).Assign("auth-addr", (AlgoSdk.Transaction x) => x.AuthAddress, (ref AlgoSdk.Transaction x, AlgoSdk.Address value) => x.AuthAddress = value).Assign("close-rewards", (AlgoSdk.Transaction x) => x.CloseRewards, (ref AlgoSdk.Transaction x, System.UInt64 value) => x.CloseRewards = value).Assign("closing-amount", (AlgoSdk.Transaction x) => x.ClosingAmount, (ref AlgoSdk.Transaction x, System.UInt64 value) => x.ClosingAmount = value).Assign("confirmed-round", (AlgoSdk.Transaction x) => x.ConfirmedRound, (ref AlgoSdk.Transaction x, System.UInt64 value) => x.ConfirmedRound = value).Assign("created-application-index", (AlgoSdk.Transaction x) => x.CreatedApplicationIndex, (ref AlgoSdk.Transaction x, System.UInt64 value) => x.CreatedApplicationIndex = value).Assign("created-asset-index", (AlgoSdk.Transaction x) => x.CreatedAssetIndex, (ref AlgoSdk.Transaction x, System.UInt64 value) => x.CreatedAssetIndex = value).Assign("intra-round-offset", (AlgoSdk.Transaction x) => x.IntraRoundOffset, (ref AlgoSdk.Transaction x, System.UInt64 value) => x.IntraRoundOffset = value).Assign("global-state-delta", (AlgoSdk.Transaction x) => x.GlobalStateDelta, (ref AlgoSdk.Transaction x, AlgoSdk.EvalDeltaKeyValue[] value) => x.GlobalStateDelta = value, AlgoSdk.ArrayComparer<AlgoSdk.EvalDeltaKeyValue>.Instance).Assign("local-state-delta", (AlgoSdk.Transaction x) => x.LocalStateDelta, (ref AlgoSdk.Transaction x, AlgoSdk.AccountStateDelta[] value) => x.LocalStateDelta = value, AlgoSdk.ArrayComparer<AlgoSdk.AccountStateDelta>.Instance).Assign("receiver-rewards", (AlgoSdk.Transaction x) => x.ReceiverRewards, (ref AlgoSdk.Transaction x, System.UInt64 value) => x.ReceiverRewards = value).Assign("round-time", (AlgoSdk.Transaction x) => x.RoundTime, (ref AlgoSdk.Transaction x, System.UInt64 value) => x.RoundTime = value).Assign("sender-rewards", (AlgoSdk.Transaction x) => x.SenderRewards, (ref AlgoSdk.Transaction x, System.UInt64 value) => x.SenderRewards = value).Assign("inner-txns", (AlgoSdk.Transaction x) => x.InnerTxns, (ref AlgoSdk.Transaction x, AlgoSdk.Transaction[] value) => x.InnerTxns = value, AlgoSdk.ArrayComparer<AlgoSdk.Transaction>.Instance));
            return true;
        }
    }
}
