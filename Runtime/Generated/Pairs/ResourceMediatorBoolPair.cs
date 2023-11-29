using System;
using UnityAtomsExtensions.ResourceMediator;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool&gt;`. Inherits from `IPair&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool&gt;`.
    /// </summary>
    [Serializable]
    public struct ResourceMediatorBoolPair : IPair<ResourceMediatorBool>
    {
        public ResourceMediatorBool Item1 { get => _item1; set => _item1 = value; }
        public ResourceMediatorBool Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private ResourceMediatorBool _item1;
        [SerializeField]
        private ResourceMediatorBool _item2;

        public void Deconstruct(out ResourceMediatorBool item1, out ResourceMediatorBool item2) { item1 = Item1; item2 = Item2; }
    }
}