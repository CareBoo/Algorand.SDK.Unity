using System;
using AlgoSdk.Crypto;
using Unity.Collections;

namespace AlgoSdk
{
    [AlgoApiObject]
    public partial struct ImportMultisigRequest
        : IEquatable<ImportMultisigRequest>
    {
        [AlgoApiField("multisig_version")]
        public byte Version;

        [AlgoApiField("pks")]
        public Ed25519.PublicKey[] PublicKeys;

        [AlgoApiField("threshold")]
        public byte Threshold;

        [AlgoApiField("wallet_handle_token")]
        public FixedString128Bytes WalletHandleToken;

        public bool Equals(ImportMultisigRequest other)
        {
            return Version.Equals(other.Version)
                && ArrayComparer.Equals(PublicKeys, other.PublicKeys)
                && Threshold.Equals(other.Threshold)
                && WalletHandleToken.Equals(other.WalletHandleToken)
                ;
        }
    }
}
