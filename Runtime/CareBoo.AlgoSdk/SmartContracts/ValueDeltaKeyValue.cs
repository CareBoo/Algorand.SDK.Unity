using System;
using Unity.Collections;
using UnityEngine;

namespace AlgoSdk
{
    [Serializable]
    public partial struct ValueDeltaKeyValue
        : IEquatable<ValueDeltaKeyValue>
    {
        [SerializeField]
        FixedString64Bytes key;

        [SerializeField]
        ValueDelta value;

        public FixedString64Bytes Key
        {
            get => this.key;
            set => this.key = value;
        }

        public ValueDelta Value
        {
            get => this.value;
            set => this.value = value;
        }

        public bool Equals(ValueDeltaKeyValue other)
        {
            return Key.Equals(other.Key)
                && Value.Equals(other.Value)
                ;
        }
    }
}
