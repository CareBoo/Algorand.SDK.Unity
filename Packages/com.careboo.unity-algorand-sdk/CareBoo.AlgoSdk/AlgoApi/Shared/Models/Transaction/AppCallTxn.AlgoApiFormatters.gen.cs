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


    public partial struct AppCallTxn
    {

        private static bool @__generated__IsValid = AppCallTxn.@__generated__InitializeAlgoApiFormatters();

        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.AppCallTxn>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.AppCallTxn>().Assign("fee", "fee", (AlgoSdk.AppCallTxn x) => x.Fee, (ref AlgoSdk.AppCallTxn x, System.UInt64 value) => x.Fee = value, false).Assign("first-valid", "fv", (AlgoSdk.AppCallTxn x) => x.FirstValidRound, (ref AlgoSdk.AppCallTxn x, System.UInt64 value) => x.FirstValidRound = value, false).Assign("genesis-hash", "gh", (AlgoSdk.AppCallTxn x) => x.GenesisHash, (ref AlgoSdk.AppCallTxn x, AlgoSdk.GenesisHash value) => x.GenesisHash = value, false).Assign("last-valid", "lv", (AlgoSdk.AppCallTxn x) => x.LastValidRound, (ref AlgoSdk.AppCallTxn x, System.UInt64 value) => x.LastValidRound = value, false).Assign("sender", "snd", (AlgoSdk.AppCallTxn x) => x.Sender, (ref AlgoSdk.AppCallTxn x, AlgoSdk.Address value) => x.Sender = value, false).Assign("tx-type", "type", (AlgoSdk.AppCallTxn x) => x.TransactionType, (ref AlgoSdk.AppCallTxn x, AlgoSdk.TransactionType value) => x.TransactionType = value, AlgoSdk.ByteEnumComparer<AlgoSdk.TransactionType>.Instance, false).Assign("genesis-id", "gen", (AlgoSdk.AppCallTxn x) => x.GenesisId, (ref AlgoSdk.AppCallTxn x, Unity.Collections.FixedString32Bytes value) => x.GenesisId = value, false).Assign("group", "grp", (AlgoSdk.AppCallTxn x) => x.Group, (ref AlgoSdk.AppCallTxn x, AlgoSdk.Crypto.Sha512_256_Hash value) => x.Group = value, false).Assign("lease", "lx", (AlgoSdk.AppCallTxn x) => x.Lease, (ref AlgoSdk.AppCallTxn x, AlgoSdk.Crypto.Sha512_256_Hash value) => x.Lease = value, false).Assign("note", "note", (AlgoSdk.AppCallTxn x) => x.Note, (ref AlgoSdk.AppCallTxn x, System.Byte[] value) => x.Note = value, AlgoSdk.ArrayComparer<byte>.Instance, false).Assign("rekey-to", "rekey", (AlgoSdk.AppCallTxn x) => x.RekeyTo, (ref AlgoSdk.AppCallTxn x, AlgoSdk.Address value) => x.RekeyTo = value, false).Assign(null, "apid", (AlgoSdk.AppCallTxn x) => x.ApplicationId, (ref AlgoSdk.AppCallTxn x, System.UInt64 value) => x.ApplicationId = value, false).Assign("on-completion", "apan", (AlgoSdk.AppCallTxn x) => x.OnComplete, (ref AlgoSdk.AppCallTxn x, AlgoSdk.OnCompletion value) => x.OnComplete = value, AlgoSdk.ByteEnumComparer<AlgoSdk.OnCompletion>.Instance, false).Assign(null, "apap", (AlgoSdk.AppCallTxn x) => x.ApprovalProgram, (ref AlgoSdk.AppCallTxn x, AlgoSdk.CompiledTeal value) => x.ApprovalProgram = value, false).Assign(null, "apsu", (AlgoSdk.AppCallTxn x) => x.ClearStateProgram, (ref AlgoSdk.AppCallTxn x, AlgoSdk.CompiledTeal value) => x.ClearStateProgram = value, false).Assign(null, "apaa", (AlgoSdk.AppCallTxn x) => x.AppArguments, (ref AlgoSdk.AppCallTxn x, AlgoSdk.CompiledTeal value) => x.AppArguments = value, false).Assign(null, "apat", (AlgoSdk.AppCallTxn x) => x.Accounts, (ref AlgoSdk.AppCallTxn x, AlgoSdk.Address[] value) => x.Accounts = value, AlgoSdk.ArrayComparer<AlgoSdk.Address>.Instance, false).Assign(null, "apfa", (AlgoSdk.AppCallTxn x) => x.ForeignApps, (ref AlgoSdk.AppCallTxn x, System.UInt64[] value) => x.ForeignApps = value, AlgoSdk.ArrayComparer<ulong>.Instance, false).Assign(null, "apas", (AlgoSdk.AppCallTxn x) => x.ForeignAssets, (ref AlgoSdk.AppCallTxn x, System.UInt64[] value) => x.ForeignAssets = value, AlgoSdk.ArrayComparer<ulong>.Instance, false).Assign(null, "apgs", (AlgoSdk.AppCallTxn x) => x.GlobalStateSchema, (ref AlgoSdk.AppCallTxn x, AlgoSdk.StateSchema value) => x.GlobalStateSchema = value, false).Assign(null, "apls", (AlgoSdk.AppCallTxn x) => x.LocalStateSchema, (ref AlgoSdk.AppCallTxn x, AlgoSdk.StateSchema value) => x.LocalStateSchema = value, false).Assign(null, "apep", (AlgoSdk.AppCallTxn x) => x.ExtraProgramPages, (ref AlgoSdk.AppCallTxn x, System.UInt64 value) => x.ExtraProgramPages = value, false));
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.TransactionType>(new AlgoSdk.Formatters.TransactionTypeFormatter());
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.TransactionType[]>(AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.TransactionType>.Instance);
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.OnCompletion>(new AlgoSdk.Formatters.OnCompletionFormatter());
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.OnCompletion[]>(AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.OnCompletion>.Instance);
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.AppCallTxn[]>(AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.AppCallTxn>.Instance);
            return true;
        }

        public partial struct Params
        {

            private static bool @__generated__IsValid = Params.@__generated__InitializeAlgoApiFormatters();

            private static bool @__generated__InitializeAlgoApiFormatters()
            {
                AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.AppCallTxn.Params>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.AppCallTxn.Params>().Assign("application-id", "apid", (AlgoSdk.AppCallTxn.Params x) => x.ApplicationId, (ref AlgoSdk.AppCallTxn.Params x, System.UInt64 value) => x.ApplicationId = value, false).Assign("on-completion", "apan", (AlgoSdk.AppCallTxn.Params x) => x.OnComplete, (ref AlgoSdk.AppCallTxn.Params x, AlgoSdk.OnCompletion value) => x.OnComplete = value, AlgoSdk.ByteEnumComparer<AlgoSdk.OnCompletion>.Instance, false).Assign("approval-program", "apap", (AlgoSdk.AppCallTxn.Params x) => x.ApprovalProgram, (ref AlgoSdk.AppCallTxn.Params x, AlgoSdk.CompiledTeal value) => x.ApprovalProgram = value, false).Assign("clear-state-program", "apsu", (AlgoSdk.AppCallTxn.Params x) => x.ClearStateProgram, (ref AlgoSdk.AppCallTxn.Params x, AlgoSdk.CompiledTeal value) => x.ClearStateProgram = value, false).Assign("application-args", "apaa", (AlgoSdk.AppCallTxn.Params x) => x.AppArguments, (ref AlgoSdk.AppCallTxn.Params x, AlgoSdk.CompiledTeal value) => x.AppArguments = value, false).Assign("accounts", "apat", (AlgoSdk.AppCallTxn.Params x) => x.Accounts, (ref AlgoSdk.AppCallTxn.Params x, AlgoSdk.Address[] value) => x.Accounts = value, AlgoSdk.ArrayComparer<AlgoSdk.Address>.Instance, false).Assign("foreign-apps", "apfa", (AlgoSdk.AppCallTxn.Params x) => x.ForeignApps, (ref AlgoSdk.AppCallTxn.Params x, System.UInt64[] value) => x.ForeignApps = value, AlgoSdk.ArrayComparer<ulong>.Instance, false).Assign("foreign-assets", "apas", (AlgoSdk.AppCallTxn.Params x) => x.ForeignAssets, (ref AlgoSdk.AppCallTxn.Params x, System.UInt64[] value) => x.ForeignAssets = value, AlgoSdk.ArrayComparer<ulong>.Instance, false).Assign("global-state-schema", "global-state-schema", (AlgoSdk.AppCallTxn.Params x) => x.GlobalStateSchema, (ref AlgoSdk.AppCallTxn.Params x, AlgoSdk.StateSchema value) => x.GlobalStateSchema = value, false).Assign("local-state-schema", "local-state-schema", (AlgoSdk.AppCallTxn.Params x) => x.LocalStateSchema, (ref AlgoSdk.AppCallTxn.Params x, AlgoSdk.StateSchema value) => x.LocalStateSchema = value, false).Assign("extra-program-pages", "epp", (AlgoSdk.AppCallTxn.Params x) => x.ExtraProgramPages, (ref AlgoSdk.AppCallTxn.Params x, System.UInt64 value) => x.ExtraProgramPages = value, false));
                AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.OnCompletion>(new AlgoSdk.Formatters.OnCompletionFormatter());
                AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.OnCompletion[]>(AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.OnCompletion>.Instance);
                AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.AppCallTxn.Params[]>(AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.AppCallTxn.Params>.Instance);
                return true;
            }
        }
    }
}
