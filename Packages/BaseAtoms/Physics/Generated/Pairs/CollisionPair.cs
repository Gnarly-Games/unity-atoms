using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityEngine.Collision&gt;`. Inherits from `IPair&lt;UnityEngine.Collision&gt;`.
    /// </summary>
    [Serializable]
    public struct CollisionPair : IPair<UnityEngine.Collision>
    {
        public UnityEngine.Collision Value { get => _value; set => _value = value; }
        public UnityEngine.Collision OldValue { get => _oldValue; set => _oldValue = value; }

        [SerializeField]
        private UnityEngine.Collision _value;
        [SerializeField]
        private UnityEngine.Collision _oldValue;

        public void Deconstruct(out UnityEngine.Collision item1, out UnityEngine.Collision item2) { item1 = Value; item2 = OldValue; }
    }
}
