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
    
    
    public partial struct KeyRegTxn
    {
        
        private static bool @__generated__IsValid = KeyRegTxn.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.KeyRegTxn>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.KeyRegTxn>(false).Assign("fee", (AlgoSdk.KeyRegTxn x) => x.Fee, (ref AlgoSdk.KeyRegTxn x, AlgoSdk.MicroAlgos value) => x.Fee = value).Assign("fv", (AlgoSdk.KeyRegTxn x) => x.FirstValidRound, (ref AlgoSdk.KeyRegTxn x, System.UInt64 value) => x.FirstValidRound = value).Assign("gh", (AlgoSdk.KeyRegTxn x) => x.GenesisHash, (ref AlgoSdk.KeyRegTxn x, AlgoSdk.GenesisHash value) => x.GenesisHash = value).Assign("lv", (AlgoSdk.KeyRegTxn x) => x.LastValidRound, (ref AlgoSdk.KeyRegTxn x, System.UInt64 value) => x.LastValidRound = value).Assign("snd", (AlgoSdk.KeyRegTxn x) => x.Sender, (ref AlgoSdk.KeyRegTxn x, AlgoSdk.Address value) => x.Sender = value).Assign("type", (AlgoSdk.KeyRegTxn x) => x.TransactionType, (ref AlgoSdk.KeyRegTxn x, AlgoSdk.TransactionType value) => x.TransactionType = value, AlgoSdk.ByteEnumComparer<AlgoSdk.TransactionType>.Instance).Assign("gen", (AlgoSdk.KeyRegTxn x) => x.GenesisId, (ref AlgoSdk.KeyRegTxn x, Unity.Collections.FixedString32Bytes value) => x.GenesisId = value).Assign("grp", (AlgoSdk.KeyRegTxn x) => x.Group, (ref AlgoSdk.KeyRegTxn x, AlgoSdk.TransactionId value) => x.Group = value).Assign("lx", (AlgoSdk.KeyRegTxn x) => x.Lease, (ref AlgoSdk.KeyRegTxn x, AlgoSdk.TransactionId value) => x.Lease = value).Assign("note", (AlgoSdk.KeyRegTxn x) => x.Note, (ref AlgoSdk.KeyRegTxn x, System.Byte[] value) => x.Note = value, AlgoSdk.ArrayComparer<System.Byte>.Instance).Assign("rekey", (AlgoSdk.KeyRegTxn x) => x.RekeyTo, (ref AlgoSdk.KeyRegTxn x, AlgoSdk.Address value) => x.RekeyTo = value).Assign("votekey", (AlgoSdk.KeyRegTxn x) => x.VoteParticipationKey, (ref AlgoSdk.KeyRegTxn x, AlgoSdk.ParticipationPublicKey value) => x.VoteParticipationKey = value).Assign("selkey", (AlgoSdk.KeyRegTxn x) => x.SelectionParticipationKey, (ref AlgoSdk.KeyRegTxn x, AlgoSdk.VrfPubKey value) => x.SelectionParticipationKey = value).Assign("votefst", (AlgoSdk.KeyRegTxn x) => x.VoteFirst, (ref AlgoSdk.KeyRegTxn x, System.UInt64 value) => x.VoteFirst = value).Assign("votelst", (AlgoSdk.KeyRegTxn x) => x.VoteLast, (ref AlgoSdk.KeyRegTxn x, System.UInt64 value) => x.VoteLast = value).Assign("votekd", (AlgoSdk.KeyRegTxn x) => x.VoteKeyDilution, (ref AlgoSdk.KeyRegTxn x, System.UInt64 value) => x.VoteKeyDilution = value).Assign("nonpart", (AlgoSdk.KeyRegTxn x) => x.NonParticipation, (ref AlgoSdk.KeyRegTxn x, AlgoSdk.Optional<System.Boolean> value) => x.NonParticipation = value));
            return true;
        }
        
        public partial struct Params
        {
            
            private static bool @__generated__IsValid = Params.@__generated__InitializeAlgoApiFormatters();
            
            private static bool @__generated__InitializeAlgoApiFormatters()
            {
                AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.KeyRegTxn.Params>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.KeyRegTxn.Params>(false).Assign("nonpart", (AlgoSdk.KeyRegTxn.Params x) => x.NonParticipation, (ref AlgoSdk.KeyRegTxn.Params x, AlgoSdk.Optional<System.Boolean> value) => x.NonParticipation = value).Assign("votekey", (AlgoSdk.KeyRegTxn.Params x) => x.VoteParticipationKey, (ref AlgoSdk.KeyRegTxn.Params x, AlgoSdk.ParticipationPublicKey value) => x.VoteParticipationKey = value).Assign("selkey", (AlgoSdk.KeyRegTxn.Params x) => x.SelectionParticipationKey, (ref AlgoSdk.KeyRegTxn.Params x, AlgoSdk.VrfPubKey value) => x.SelectionParticipationKey = value).Assign("votefst", (AlgoSdk.KeyRegTxn.Params x) => x.VoteFirst, (ref AlgoSdk.KeyRegTxn.Params x, System.UInt64 value) => x.VoteFirst = value).Assign("votelst", (AlgoSdk.KeyRegTxn.Params x) => x.VoteLast, (ref AlgoSdk.KeyRegTxn.Params x, System.UInt64 value) => x.VoteLast = value).Assign("votekd", (AlgoSdk.KeyRegTxn.Params x) => x.VoteKeyDilution, (ref AlgoSdk.KeyRegTxn.Params x, System.UInt64 value) => x.VoteKeyDilution = value));
                return true;
            }
        }
    }
}
