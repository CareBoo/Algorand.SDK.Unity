using System;
using AlgoSdk.MsgPack;

namespace AlgoSdk
{
    [AlgoApiObject]
    public struct ApplicationStateSchema
        : IEquatable<ApplicationStateSchema>
        , IMessagePackObject
    {
        [AlgoApiKey("num-byte-slice")]
        public ulong NumByteSlices;

        [AlgoApiKey("num-uint")]
        public ulong NumUints;

        public bool Equals(ApplicationStateSchema other)
        {
            return this.Equals(ref other);
        }
    }
}

namespace AlgoSdk.MsgPack
{
    internal static partial class FieldMaps
    {
        internal static readonly Field<ApplicationStateSchema>.Map applicationStateSchemaFields =
            new Field<ApplicationStateSchema>.Map()
                .Assign("num-byte-slice", (ref ApplicationStateSchema x) => ref x.NumByteSlices)
                .Assign("num-uint", (ref ApplicationStateSchema x) => ref x.NumUints)
                ;
    }
}
