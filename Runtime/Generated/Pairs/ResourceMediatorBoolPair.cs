using System;
using UnityEngine;
using UnityAtomsExtensions.PrioritizedValues;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool&gt;`. Inherits from `IPair&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool&gt;`.
    /// </summary>
    [Serializable]
    public struct ResourceMediatorBoolPair : IPair<UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool>
    {
        public UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool Item1 { get => _item1; set => _item1 = value; }
        public UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool _item1;
        [SerializeField]
        private UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool _item2;

        public void Deconstruct(out UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool item1, out UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool item2) { item1 = Item1; item2 = Item2; }
    }
}