using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityEngine.Collider&gt;`. Inherits from `IPair&lt;UnityEngine.Collider&gt;`.
    /// </summary>
    [Serializable]
    public struct ColliderPair : IPair<UnityEngine.Collider>
    {
        public UnityEngine.Collider Value { get => value; set => this.value = value; }
        public UnityEngine.Collider OldValue { get => oldValue; set => oldValue = value; }

        [FormerlySerializedAs("_item1"),SerializeField]
        private UnityEngine.Collider value;
        [FormerlySerializedAs("_item2"),SerializeField]
        private UnityEngine.Collider oldValue;

        public void Deconstruct(out UnityEngine.Collider item1, out UnityEngine.Collider item2) { item1 = Value; item2 = OldValue; }
    }
}
