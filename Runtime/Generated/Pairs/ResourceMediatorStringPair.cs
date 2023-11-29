using System;
using UnityEngine;
using UnityAtomsExtensions.PrioritizedValues;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString&gt;`. Inherits from `IPair&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString&gt;`.
    /// </summary>
    [Serializable]
    public struct ResourceMediatorStringPair : IPair<UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString>
    {
        public UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString Item1 { get => _item1; set => _item1 = value; }
        public UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString _item1;
        [SerializeField]
        private UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString _item2;

        public void Deconstruct(out UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString item1, out UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString item2) { item1 = Item1; item2 = Item2; }
    }
}