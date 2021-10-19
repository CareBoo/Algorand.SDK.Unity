using AlgoSdk.MessagePack;
using Unity.Collections;

namespace AlgoSdk.Formatters
{
    public sealed class OnCompletionFormatter : KeywordByteEnumFormatter<OnCompletion>
    {
        private static readonly FixedString32Bytes[] typeToString = new FixedString32Bytes[]
        {
            default,
            "noop",
            "optin",
            "closeout",
            "clear",
            "update",
            "delete"
        };

        public OnCompletionFormatter() : base(typeToString) { }

        public override OnCompletion Deserialize(ref MessagePackReader reader)
        {
            return (OnCompletion)reader.ReadByte();
        }

        public override void Serialize(ref MessagePackWriter writer, OnCompletion value)
        {
            writer.Write((byte)value);
        }
    }
}
