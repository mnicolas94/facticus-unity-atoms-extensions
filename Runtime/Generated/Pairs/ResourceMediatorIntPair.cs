using System;
using UnityEngine;
using UnityAtomsExtensions.PrioritizedValues;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt&gt;`. Inherits from `IPair&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt&gt;`.
    /// </summary>
    [Serializable]
    public struct ResourceMediatorIntPair : IPair<UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt>
    {
        public UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt Item1 { get => _item1; set => _item1 = value; }
        public UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt _item1;
        [SerializeField]
        private UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt _item2;

        public void Deconstruct(out UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt item1, out UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt item2) { item1 = Item1; item2 = Item2; }
    }
}