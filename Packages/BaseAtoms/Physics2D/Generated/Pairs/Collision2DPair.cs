using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityEngine.Collision2D&gt;`. Inherits from `IPair&lt;UnityEngine.Collision2D&gt;`.
    /// </summary>
    [Serializable]
    public struct Collision2DPair : IPair<UnityEngine.Collision2D>
    {
        public UnityEngine.Collision2D Value { get => _value; set => _value = value; }
        public UnityEngine.Collision2D OldValue { get => _oldValue; set => _oldValue = value; }

        [SerializeField]
        private UnityEngine.Collision2D _value;
        [SerializeField]
        private UnityEngine.Collision2D _oldValue;

        public void Deconstruct(out UnityEngine.Collision2D item1, out UnityEngine.Collision2D item2) { item1 = Value; item2 = OldValue; }
    }
}
