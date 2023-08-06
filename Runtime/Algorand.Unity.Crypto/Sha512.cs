using System;
using System.Runtime.InteropServices;
using Algorand.Unity.LowLevel;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static Algorand.Unity.Crypto.sodium;

namespace Algorand.Unity.Crypto
{
    public static class Sha512
    {
        internal static readonly Sha512StateVector FIPS_Sha512_256_IV = new ulong[8]
        {
            Convert.ToUInt64("22312194FC2BF72C", 16),
            Convert.ToUInt64("9F555FA3C84C64C2", 16),
            Convert.ToUInt64("2393B86B6F53B151", 16),
            Convert.ToUInt64("963877195940EABD", 16),
            Convert.ToUInt64("96283EE2A88EFFE3", 16),
            Convert.ToUInt64("BE5E1E2553863992", 16),
            Convert.ToUInt64("2B0199FC2C85B8AA", 16),
            Convert.ToUInt64("0EB72DDC81C52CA2", 16)
        };

        public static Sha512_256_Hash Hash256Truncated<TByteArray>(TByteArray bytes)
            where TByteArray : struct, IByteArray
        {
            unsafe
            {
                return Hash256Truncated((byte*)bytes.GetUnsafePtr(), bytes.Length);
            }
        }

        public static Sha512_256_Hash Hash256Truncated(NativeArray<byte>.ReadOnly bytes)
        {
            unsafe
            {
                return Hash256Truncated((byte*)bytes.GetUnsafeReadOnlyPtr(), bytes.Length);
            }
        }

        public static unsafe Sha512_256_Hash Hash256Truncated(byte* ptr, int length)
        {
            var result = new Sha512_256_Hash();
            var hashState = default(crypto_hash_sha512_state);
            crypto_hash_sha512_init(&hashState);
            hashState.vector = FIPS_Sha512_256_IV;
            crypto_hash_sha512_update(&hashState, ptr, (ulong)length);
            var hash512 = new Sha512_Hash();
            crypto_hash_sha512_final(&hashState, &hash512);
            hash512.CopyTo(ref result);
            return result;
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = SizeBytes)]
    [Serializable]
    public struct Sha512_256_Hash
        : IByteArray
            , IEquatable<Sha512_256_Hash>
    {
        public const int SizeBytes = 256 / 8;

        [FieldOffset(0)]
        [SerializeField]
        internal FixedBytes16 offset0000;

        [FieldOffset(16)]
        [SerializeField]
        internal FixedBytes16 offset0016;

        public unsafe void* GetUnsafePtr()
        {
            fixed (byte* b = &offset0000.byte0000)
            {
                return b;
            }
        }

        public int Length => SizeBytes;

        public byte this[int index]
        {
            get => this.GetByteAt(index);
            set => this.SetByteAt(index, value);
        }

        public bool Equals(Sha512_256_Hash other)
        {
            return ByteArray.Equals(this, other);
        }

        public static bool operator ==(in Sha512_256_Hash x, in Sha512_256_Hash y)
        {
            return ByteArray.Equals(x, y);
        }

        public static bool operator !=(in Sha512_256_Hash x, in Sha512_256_Hash y)
        {
            return !ByteArray.Equals(x, y);
        }

        public override bool Equals(object obj)
        {
            return ByteArray.Equals(this, obj);
        }

        public override int GetHashCode()
        {
            return ByteArray.GetHashCode(this);
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = SizeBytes)]
    public struct Sha512_Hash
        : IByteArray
            , IEquatable<Sha512_Hash>
    {
        public const int SizeBytes = 512 / 8;

        [FieldOffset(0)]
        internal FixedBytes16 offset0000;

        [FieldOffset(16)]
        internal FixedBytes16 offset0016;

        [FieldOffset(32)]
        internal FixedBytes16 offset0032;

        [FieldOffset(48)]
        internal FixedBytes16 offset0048;

        public unsafe void* GetUnsafePtr()
        {
            fixed (byte* b = &offset0000.byte0000)
            {
                return b;
            }
        }

        public int Length => SizeBytes;

        public byte this[int index]
        {
            get => this.GetByteAt(index);
            set => this.SetByteAt(index, value);
        }

        public bool Equals(Sha512_Hash other)
        {
            for (var i = 0; i < Length; i++)
                if (this[i] != other[i])
                    return false;
            return true;
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    internal struct Sha512StateVector
    {
        public const int Length = 8;

        [FieldOffset(0)]
        internal FixedBytes64 buffer;

        internal unsafe byte* Buffer
        {
            get
            {
                fixed (byte* b = &buffer.offset0000.offset0000.byte0000)
                {
                    return b;
                }
            }
        }

        public ulong this[int index]
        {
            get
            {
                ByteArray.CheckElementAccess(index, Length);
                unsafe
                {
                    return UnsafeUtility.ReadArrayElement<ulong>(Buffer, index);
                }
            }
            set
            {
                ByteArray.CheckElementAccess(index, Length);
                unsafe
                {
                    UnsafeUtility.WriteArrayElement(Buffer, index, value);
                }
            }
        }

        public static implicit operator Sha512StateVector(ulong[] arr)
        {
            var result = new Sha512StateVector();
            for (var i = 0; i < arr.Length; i++)
                result[i] = arr[i];
            return result;
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    internal struct Sha512StateCount
    {
        public const int Length = 2;

        [FieldOffset(0)]
        internal FixedBytes16 buffer;

        internal unsafe byte* Buffer
        {
            get
            {
                fixed (byte* b = &buffer.byte0000)
                {
                    return b;
                }
            }
        }

        public ulong this[int index]
        {
            get
            {
                ByteArray.CheckElementAccess(index, Length);
                unsafe
                {
                    return UnsafeUtility.ReadArrayElement<ulong>(Buffer, index);
                }
            }
            set
            {
                ByteArray.CheckElementAccess(index, Length);
                unsafe
                {
                    UnsafeUtility.WriteArrayElement(Buffer, index, value);
                }
            }
        }
    }
}