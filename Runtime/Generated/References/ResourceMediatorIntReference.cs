using System;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt`. Inherits from `AtomReference&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt, ResourceMediatorIntPair, ResourceMediatorIntConstant, ResourceMediatorIntVariable, ResourceMediatorIntEvent, ResourceMediatorIntPairEvent, ResourceMediatorIntResourceMediatorIntFunction, ResourceMediatorIntVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorIntReference : AtomReference<
        ResourceMediatorInt,
        ResourceMediatorIntPair,
        ResourceMediatorIntConstant,
        ResourceMediatorIntVariable,
        ResourceMediatorIntEvent,
        ResourceMediatorIntPairEvent,
        ResourceMediatorIntResourceMediatorIntFunction,
        ResourceMediatorIntVariableInstancer>, IEquatable<ResourceMediatorIntReference>
    {
        public ResourceMediatorIntReference() : base() { }
        public ResourceMediatorIntReference(ResourceMediatorInt value) : base(value) { }
        public bool Equals(ResourceMediatorIntReference other) { return base.Equals(other); }
        protected override bool ValueEquals(ResourceMediatorInt other)
        {
            throw new NotImplementedException();
        }
    }
}
