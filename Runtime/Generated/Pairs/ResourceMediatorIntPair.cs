using System;
using UnityAtomsExtensions.ResourceMediator;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt&gt;`. Inherits from `IPair&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt&gt;`.
    /// </summary>
    [Serializable]
    public struct ResourceMediatorIntPair : IPair<ResourceMediatorInt>
    {
        public ResourceMediatorInt Item1 { get => _item1; set => _item1 = value; }
        public ResourceMediatorInt Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private ResourceMediatorInt _item1;
        [SerializeField]
        private ResourceMediatorInt _item2;

        public void Deconstruct(out ResourceMediatorInt item1, out ResourceMediatorInt item2) { item1 = Item1; item2 = Item2; }
    }
}