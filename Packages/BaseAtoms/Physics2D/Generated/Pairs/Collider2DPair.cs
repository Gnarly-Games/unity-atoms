using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityEngine.Collider2D&gt;`. Inherits from `IPair&lt;UnityEngine.Collider2D&gt;`.
    /// </summary>
    [Serializable]
    public struct Collider2DPair : IPair<UnityEngine.Collider2D>
    {
        public UnityEngine.Collider2D Value { get => value; set => this.value = value; }
        public UnityEngine.Collider2D OldValue { get => oldValue; set => oldValue = value; }

        [FormerlySerializedAs("_item1"),SerializeField]
        private UnityEngine.Collider2D value;
        [FormerlySerializedAs("_item2"),SerializeField]
        private UnityEngine.Collider2D oldValue;

        public void Deconstruct(out UnityEngine.Collider2D item1, out UnityEngine.Collider2D item2) { item1 = Value; item2 = OldValue; }
    }
}
