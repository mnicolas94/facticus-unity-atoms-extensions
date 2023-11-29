using System;
using UnityAtomsExtensions.ResourceMediator;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat&gt;`. Inherits from `IPair&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat&gt;`.
    /// </summary>
    [Serializable]
    public struct ResourceMediatorFloatPair : IPair<ResourceMediatorFloat>
    {
        public ResourceMediatorFloat Item1 { get => _item1; set => _item1 = value; }
        public ResourceMediatorFloat Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private ResourceMediatorFloat _item1;
        [SerializeField]
        private ResourceMediatorFloat _item2;

        public void Deconstruct(out ResourceMediatorFloat item1, out ResourceMediatorFloat item2) { item1 = Item1; item2 = Item2; }
    }
}