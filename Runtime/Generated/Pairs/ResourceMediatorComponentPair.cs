using System;
using UnityEngine;
using UnityAtomsExtensions.PrioritizedValues;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent&gt;`. Inherits from `IPair&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent&gt;`.
    /// </summary>
    [Serializable]
    public struct ResourceMediatorComponentPair : IPair<UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent>
    {
        public UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent Item1 { get => _item1; set => _item1 = value; }
        public UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent _item1;
        [SerializeField]
        private UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent _item2;

        public void Deconstruct(out UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent item1, out UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent item2) { item1 = Item1; item2 = Item2; }
    }
}