using System;
using Unity.Collections;

namespace AlgoSdk.Kmd
{
    [AlgoApiObject]
    public partial struct VersionsResponse
        : IEquatable<VersionsResponse>
    {
        [AlgoApiField("versions")]
        public FixedString64Bytes[] Versions;

        public bool Equals(VersionsResponse other)
        {
            return ArrayComparer.Equals(Versions, other.Versions);
        }
    }
}
