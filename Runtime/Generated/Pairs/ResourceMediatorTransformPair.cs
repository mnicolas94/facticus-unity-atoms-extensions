using System;
using UnityEngine;
using UnityAtomsExtensions.PrioritizedValues;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform&gt;`. Inherits from `IPair&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform&gt;`.
    /// </summary>
    [Serializable]
    public struct ResourceMediatorTransformPair : IPair<UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform>
    {
        public UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform Item1 { get => _item1; set => _item1 = value; }
        public UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform _item1;
        [SerializeField]
        private UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform _item2;

        public void Deconstruct(out UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform item1, out UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform item2) { item1 = Item1; item2 = Item2; }
    }
}