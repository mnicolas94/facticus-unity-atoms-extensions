using System;
using UnityAtomsExtensions.ResourceMediator;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform&gt;`. Inherits from `IPair&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform&gt;`.
    /// </summary>
    [Serializable]
    public struct ResourceMediatorTransformPair : IPair<ResourceMediatorTransform>
    {
        public ResourceMediatorTransform Item1 { get => _item1; set => _item1 = value; }
        public ResourceMediatorTransform Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private ResourceMediatorTransform _item1;
        [SerializeField]
        private ResourceMediatorTransform _item2;

        public void Deconstruct(out ResourceMediatorTransform item1, out ResourceMediatorTransform item2) { item1 = Item1; item2 = Item2; }
    }
}