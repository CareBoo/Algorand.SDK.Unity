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
    
    
    public partial struct SignProgramMultisigRequest
    {
        
        private static bool @__generated__IsValid = SignProgramMultisigRequest.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.SignProgramMultisigRequest>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.SignProgramMultisigRequest>(false).Assign("address", (AlgoSdk.SignProgramMultisigRequest x) => x.Address, (ref AlgoSdk.SignProgramMultisigRequest x, AlgoSdk.Address value) => x.Address = value).Assign("data", (AlgoSdk.SignProgramMultisigRequest x) => x.Data, (ref AlgoSdk.SignProgramMultisigRequest x, System.Byte[] value) => x.Data = value, AlgoSdk.ArrayComparer<System.Byte>.Instance).Assign("partial_multisig", (AlgoSdk.SignProgramMultisigRequest x) => x.Multisig, (ref AlgoSdk.SignProgramMultisigRequest x, AlgoSdk.Multisig value) => x.Multisig = value).Assign("public_key", (AlgoSdk.SignProgramMultisigRequest x) => x.PublicKey, (ref AlgoSdk.SignProgramMultisigRequest x, AlgoSdk.Crypto.Ed25519.PublicKey value) => x.PublicKey = value).Assign("wallet_handle_token", (AlgoSdk.SignProgramMultisigRequest x) => x.WalletHandleToken, (ref AlgoSdk.SignProgramMultisigRequest x, Unity.Collections.FixedString128Bytes value) => x.WalletHandleToken = value).Assign("wallet_password", (AlgoSdk.SignProgramMultisigRequest x) => x.WalletPassword, (ref AlgoSdk.SignProgramMultisigRequest x, Unity.Collections.FixedString128Bytes value) => x.WalletPassword = value));
            return true;
        }
    }
}
