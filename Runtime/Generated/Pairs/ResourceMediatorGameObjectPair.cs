using System;
using UnityEngine;
using UnityAtomsExtensions.PrioritizedValues;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject&gt;`. Inherits from `IPair&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject&gt;`.
    /// </summary>
    [Serializable]
    public struct ResourceMediatorGameObjectPair : IPair<UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject>
    {
        public UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject Item1 { get => _item1; set => _item1 = value; }
        public UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject _item1;
        [SerializeField]
        private UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject _item2;

        public void Deconstruct(out UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject item1, out UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject item2) { item1 = Item1; item2 = Item2; }
    }
}