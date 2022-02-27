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
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.PaymentTxn>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.PaymentTxn>().Assign("fee", "fee", (AlgoSdk.PaymentTxn x) => x.Fee, (ref AlgoSdk.PaymentTxn x, System.UInt64 value) => x.Fee = value, false).Assign("first-valid", "fv", (AlgoSdk.PaymentTxn x) => x.FirstValidRound, (ref AlgoSdk.PaymentTxn x, System.UInt64 value) => x.FirstValidRound = value, false).Assign("genesis-hash", "gh", (AlgoSdk.PaymentTxn x) => x.GenesisHash, (ref AlgoSdk.PaymentTxn x, AlgoSdk.GenesisHash value) => x.GenesisHash = value, false).Assign("last-valid", "lv", (AlgoSdk.PaymentTxn x) => x.LastValidRound, (ref AlgoSdk.PaymentTxn x, System.UInt64 value) => x.LastValidRound = value, false).Assign("sender", "snd", (AlgoSdk.PaymentTxn x) => x.Sender, (ref AlgoSdk.PaymentTxn x, AlgoSdk.Address value) => x.Sender = value, false).Assign("tx-type", "type", (AlgoSdk.PaymentTxn x) => x.TransactionType, (ref AlgoSdk.PaymentTxn x, AlgoSdk.TransactionType value) => x.TransactionType = value, AlgoSdk.ByteEnumComparer<AlgoSdk.TransactionType>.Instance, false).Assign("genesis-id", "gen", (AlgoSdk.PaymentTxn x) => x.GenesisId, (ref AlgoSdk.PaymentTxn x, Unity.Collections.FixedString32Bytes value) => x.GenesisId = value, false).Assign("group", "grp", (AlgoSdk.PaymentTxn x) => x.Group, (ref AlgoSdk.PaymentTxn x, AlgoSdk.Crypto.Sha512_256_Hash value) => x.Group = value, false).Assign("lease", "lx", (AlgoSdk.PaymentTxn x) => x.Lease, (ref AlgoSdk.PaymentTxn x, AlgoSdk.Crypto.Sha512_256_Hash value) => x.Lease = value, false).Assign("note", "note", (AlgoSdk.PaymentTxn x) => x.Note, (ref AlgoSdk.PaymentTxn x, System.Byte[] value) => x.Note = value, AlgoSdk.ArrayComparer<byte>.Instance, false).Assign("rekey-to", "rekey", (AlgoSdk.PaymentTxn x) => x.RekeyTo, (ref AlgoSdk.PaymentTxn x, AlgoSdk.Address value) => x.RekeyTo = value, false).Assign(null, "rcv", (AlgoSdk.PaymentTxn x) => x.Receiver, (ref AlgoSdk.PaymentTxn x, AlgoSdk.Address value) => x.Receiver = value, false).Assign(null, "amt", (AlgoSdk.PaymentTxn x) => x.Amount, (ref AlgoSdk.PaymentTxn x, System.UInt64 value) => x.Amount = value, false).Assign(null, "close", (AlgoSdk.PaymentTxn x) => x.CloseRemainderTo, (ref AlgoSdk.PaymentTxn x, AlgoSdk.Address value) => x.CloseRemainderTo = value, false).Assign("close-amount", "close-amount", (AlgoSdk.PaymentTxn x) => x.CloseAmount, (ref AlgoSdk.PaymentTxn x, System.UInt64 value) => x.CloseAmount = value, false));
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.TransactionType>(new AlgoSdk.Formatters.TransactionTypeFormatter());
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.TransactionType[]>(AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.TransactionType>.Instance);
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.PaymentTxn[]>(AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.PaymentTxn>.Instance);
            return true;
        }

        public partial struct Params
        {

            private static bool @__generated__IsValid = Params.@__generated__InitializeAlgoApiFormatters();

            private static bool @__generated__InitializeAlgoApiFormatters()
            {
                AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.PaymentTxn.Params>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.PaymentTxn.Params>().Assign("receiver", "rcv", (AlgoSdk.PaymentTxn.Params x) => x.Receiver, (ref AlgoSdk.PaymentTxn.Params x, AlgoSdk.Address value) => x.Receiver = value, false).Assign("amount", "amt", (AlgoSdk.PaymentTxn.Params x) => x.Amount, (ref AlgoSdk.PaymentTxn.Params x, System.UInt64 value) => x.Amount = value, false).Assign("close-remainder-to", "close", (AlgoSdk.PaymentTxn.Params x) => x.CloseRemainderTo, (ref AlgoSdk.PaymentTxn.Params x, AlgoSdk.Address value) => x.CloseRemainderTo = value, false).Assign("close-amount", "close-amount", (AlgoSdk.PaymentTxn.Params x) => x.CloseAmount, (ref AlgoSdk.PaymentTxn.Params x, System.UInt64 value) => x.CloseAmount = value, false));
                AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.PaymentTxn.Params[]>(AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.PaymentTxn.Params>.Instance);
                return true;
            }
        }
    }
}
