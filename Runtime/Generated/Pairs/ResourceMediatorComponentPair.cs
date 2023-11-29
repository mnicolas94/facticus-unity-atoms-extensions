using System;
using UnityAtomsExtensions.ResourceMediator;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent&gt;`. Inherits from `IPair&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent&gt;`.
    /// </summary>
    [Serializable]
    public struct ResourceMediatorComponentPair : IPair<ResourceMediatorComponent>
    {
        public ResourceMediatorComponent Item1 { get => _item1; set => _item1 = value; }
        public ResourceMediatorComponent Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private ResourceMediatorComponent _item1;
        [SerializeField]
        private ResourceMediatorComponent _item2;

        public void Deconstruct(out ResourceMediatorComponent item1, out ResourceMediatorComponent item2) { item1 = Item1; item2 = Item2; }
    }
}