using System;
using UnityAtomsExtensions.ResourceMediator;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject&gt;`. Inherits from `IPair&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject&gt;`.
    /// </summary>
    [Serializable]
    public struct ResourceMediatorGameObjectPair : IPair<ResourceMediatorGameObject>
    {
        public ResourceMediatorGameObject Item1 { get => _item1; set => _item1 = value; }
        public ResourceMediatorGameObject Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private ResourceMediatorGameObject _item1;
        [SerializeField]
        private ResourceMediatorGameObject _item2;

        public void Deconstruct(out ResourceMediatorGameObject item1, out ResourceMediatorGameObject item2) { item1 = Item1; item2 = Item2; }
    }
}