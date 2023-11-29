using System;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt`. Inherits from `AtomReference&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt, ResourceMediatorIntPair, ResourceMediatorIntConstant, ResourceMediatorIntVariable, ResourceMediatorIntEvent, ResourceMediatorIntPairEvent, ResourceMediatorIntResourceMediatorIntFunction, ResourceMediatorIntVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorIntReference : AtomReference<
        UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt,
        ResourceMediatorIntPair,
        ResourceMediatorIntConstant,
        ResourceMediatorIntVariable,
        ResourceMediatorIntEvent,
        ResourceMediatorIntPairEvent,
        ResourceMediatorIntResourceMediatorIntFunction,
        ResourceMediatorIntVariableInstancer>, IEquatable<ResourceMediatorIntReference>
    {
        public ResourceMediatorIntReference() : base() { }
        public ResourceMediatorIntReference(UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt value) : base(value) { }
        public bool Equals(ResourceMediatorIntReference other) { return base.Equals(other); }
        protected override bool ValueEquals(UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt other)
        {
            throw new NotImplementedException();
        }
    }
}
