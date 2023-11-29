using System;
using UnityEngine;
using UnityAtomsExtensions.PrioritizedValues;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat&gt;`. Inherits from `IPair&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat&gt;`.
    /// </summary>
    [Serializable]
    public struct ResourceMediatorFloatPair : IPair<UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat>
    {
        public UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat Item1 { get => _item1; set => _item1 = value; }
        public UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat _item1;
        [SerializeField]
        private UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat _item2;

        public void Deconstruct(out UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat item1, out UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat item2) { item1 = Item1; item2 = Item2; }
    }
}