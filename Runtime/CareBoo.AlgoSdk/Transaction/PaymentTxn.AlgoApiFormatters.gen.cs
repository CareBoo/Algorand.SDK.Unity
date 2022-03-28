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
    
    
    public partial struct PaymentTxn
    {
        
        private static bool @__generated__IsValid = PaymentTxn.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.PaymentTxn>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.PaymentTxn>(false).Assign("fee", (AlgoSdk.PaymentTxn x) => x.Fee, (ref AlgoSdk.PaymentTxn x, AlgoSdk.MicroAlgos value) => x.Fee = value).Assign("fv", (AlgoSdk.PaymentTxn x) => x.FirstValidRound, (ref AlgoSdk.PaymentTxn x, System.UInt64 value) => x.FirstValidRound = value).Assign("gh", (AlgoSdk.PaymentTxn x) => x.GenesisHash, (ref AlgoSdk.PaymentTxn x, AlgoSdk.GenesisHash value) => x.GenesisHash = value).Assign("lv", (AlgoSdk.PaymentTxn x) => x.LastValidRound, (ref AlgoSdk.PaymentTxn x, System.UInt64 value) => x.LastValidRound = value).Assign("snd", (AlgoSdk.PaymentTxn x) => x.Sender, (ref AlgoSdk.PaymentTxn x, AlgoSdk.Address value) => x.Sender = value).Assign("type", (AlgoSdk.PaymentTxn x) => x.TransactionType, (ref AlgoSdk.PaymentTxn x, AlgoSdk.TransactionType value) => x.TransactionType = value, AlgoSdk.ByteEnumComparer<AlgoSdk.TransactionType>.Instance).Assign("gen", (AlgoSdk.PaymentTxn x) => x.GenesisId, (ref AlgoSdk.PaymentTxn x, Unity.Collections.FixedString32Bytes value) => x.GenesisId = value).Assign("grp", (AlgoSdk.PaymentTxn x) => x.Group, (ref AlgoSdk.PaymentTxn x, AlgoSdk.TransactionId value) => x.Group = value).Assign("lx", (AlgoSdk.PaymentTxn x) => x.Lease, (ref AlgoSdk.PaymentTxn x, AlgoSdk.TransactionId value) => x.Lease = value).Assign("note", (AlgoSdk.PaymentTxn x) => x.Note, (ref AlgoSdk.PaymentTxn x, System.Byte[] value) => x.Note = value, AlgoSdk.ArrayComparer<System.Byte>.Instance).Assign("rekey", (AlgoSdk.PaymentTxn x) => x.RekeyTo, (ref AlgoSdk.PaymentTxn x, AlgoSdk.Address value) => x.RekeyTo = value).Assign("rcv", (AlgoSdk.PaymentTxn x) => x.Receiver, (ref AlgoSdk.PaymentTxn x, AlgoSdk.Address value) => x.Receiver = value).Assign("amt", (AlgoSdk.PaymentTxn x) => x.Amount, (ref AlgoSdk.PaymentTxn x, AlgoSdk.MicroAlgos value) => x.Amount = value).Assign("close", (AlgoSdk.PaymentTxn x) => x.CloseRemainderTo, (ref AlgoSdk.PaymentTxn x, AlgoSdk.Address value) => x.CloseRemainderTo = value).Assign("close-amount", (AlgoSdk.PaymentTxn x) => x.CloseAmount, (ref AlgoSdk.PaymentTxn x, System.UInt64 value) => x.CloseAmount = value));
            return true;
        }
        
        public partial struct Params
        {
            
            private static bool @__generated__IsValid = Params.@__generated__InitializeAlgoApiFormatters();
            
            private static bool @__generated__InitializeAlgoApiFormatters()
            {
                AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.PaymentTxn.Params>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.PaymentTxn.Params>(false).Assign("rcv", (AlgoSdk.PaymentTxn.Params x) => x.Receiver, (ref AlgoSdk.PaymentTxn.Params x, AlgoSdk.Address value) => x.Receiver = value).Assign("amt", (AlgoSdk.PaymentTxn.Params x) => x.Amount, (ref AlgoSdk.PaymentTxn.Params x, AlgoSdk.MicroAlgos value) => x.Amount = value).Assign("close", (AlgoSdk.PaymentTxn.Params x) => x.CloseRemainderTo, (ref AlgoSdk.PaymentTxn.Params x, AlgoSdk.Address value) => x.CloseRemainderTo = value).Assign("close-amount", (AlgoSdk.PaymentTxn.Params x) => x.CloseAmount, (ref AlgoSdk.PaymentTxn.Params x, System.UInt64 value) => x.CloseAmount = value));
                return true;
            }
        }
    }
}
