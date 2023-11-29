using System;
using UnityAtomsExtensions.ResourceMediator;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString&gt;`. Inherits from `IPair&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString&gt;`.
    /// </summary>
    [Serializable]
    public struct ResourceMediatorStringPair : IPair<ResourceMediatorString>
    {
        public ResourceMediatorString Item1 { get => _item1; set => _item1 = value; }
        public ResourceMediatorString Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private ResourceMediatorString _item1;
        [SerializeField]
        private ResourceMediatorString _item2;

        public void Deconstruct(out ResourceMediatorString item1, out ResourceMediatorString item2) { item1 = Item1; item2 = Item2; }
    }
}