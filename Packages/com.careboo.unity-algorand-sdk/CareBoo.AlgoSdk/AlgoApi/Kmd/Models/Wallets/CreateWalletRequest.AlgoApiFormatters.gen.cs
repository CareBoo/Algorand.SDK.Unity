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


    public partial struct CreateWalletRequest
    {

        private static bool @__generated__IsValid = CreateWalletRequest.@__generated__InitializeAlgoApiFormatters();

        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.CreateWalletRequest>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.CreateWalletRequest>().Assign("master_derivation_key", null, (AlgoSdk.CreateWalletRequest x) => x.MasterDerivationKey, (ref AlgoSdk.CreateWalletRequest x, AlgoSdk.PrivateKey value) => x.MasterDerivationKey = value, false).Assign("wallet_driver_name", null, (AlgoSdk.CreateWalletRequest x) => x.WalletDriverName, (ref AlgoSdk.CreateWalletRequest x, Unity.Collections.FixedString128Bytes value) => x.WalletDriverName = value, false).Assign("wallet_name", null, (AlgoSdk.CreateWalletRequest x) => x.WalletName, (ref AlgoSdk.CreateWalletRequest x, Unity.Collections.FixedString128Bytes value) => x.WalletName = value, false).Assign("wallet_password", null, (AlgoSdk.CreateWalletRequest x) => x.WalletPassword, (ref AlgoSdk.CreateWalletRequest x, Unity.Collections.FixedString128Bytes value) => x.WalletPassword = value, false));
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.CreateWalletRequest[]>(AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.CreateWalletRequest>.Instance);
            return true;
        }
    }
}
