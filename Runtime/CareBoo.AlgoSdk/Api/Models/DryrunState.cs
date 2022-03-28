using System;
using Unity.Collections;
using UnityEngine;

namespace AlgoSdk
{
    /// <summary>
    /// Stores the TEAL eval step data
    /// </summary>
    [AlgoApiObject]
    [Serializable]
    public partial struct DryrunState
        : IEquatable<DryrunState>
    {
        /// <summary>
        /// Evaluation error if any
        /// </summary>
        [AlgoApiField("error")]
        [Tooltip("Evaluation error if any")]
        public FixedString128Bytes Error;

        /// <summary>
        /// Line number
        /// </summary>
        [AlgoApiField("line")]
        [Tooltip("Line number")]
        public ulong Line;

        /// <summary>
        /// Program counter
        /// </summary>
        [AlgoApiField("pc")]
        [Tooltip("Program counter")]
        public ulong ProgramCounter;

        [AlgoApiField("scratch")]
        public TealValue[] Scratch;

        [AlgoApiField("stack")]
        public TealValue[] Stack;

        public bool Equals(DryrunState other)
        {
            return Error.Equals(other.Error)
                && Line.Equals(other.Line)
                && ProgramCounter.Equals(other.ProgramCounter)
                && ArrayComparer.Equals(Scratch, other.Scratch)
                && ArrayComparer.Equals(Stack, other.Stack);
            ;
        }
    }
}
