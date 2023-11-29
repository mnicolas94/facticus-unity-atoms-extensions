using System;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString`. Inherits from `AtomReference&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString, ResourceMediatorStringPair, ResourceMediatorStringConstant, ResourceMediatorStringVariable, ResourceMediatorStringEvent, ResourceMediatorStringPairEvent, ResourceMediatorStringResourceMediatorStringFunction, ResourceMediatorStringVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorStringReference : AtomReference<
        UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString,
        ResourceMediatorStringPair,
        ResourceMediatorStringConstant,
        ResourceMediatorStringVariable,
        ResourceMediatorStringEvent,
        ResourceMediatorStringPairEvent,
        ResourceMediatorStringResourceMediatorStringFunction,
        ResourceMediatorStringVariableInstancer>, IEquatable<ResourceMediatorStringReference>
    {
        public ResourceMediatorStringReference() : base() { }
        public ResourceMediatorStringReference(UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString value) : base(value) { }
        public bool Equals(ResourceMediatorStringReference other) { return base.Equals(other); }
        protected override bool ValueEquals(UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString other)
        {
            throw new NotImplementedException();
        }
    }
}
