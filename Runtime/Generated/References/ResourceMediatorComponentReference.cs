using System;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent`. Inherits from `AtomReference&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent, ResourceMediatorComponentPair, ResourceMediatorComponentConstant, ResourceMediatorComponentVariable, ResourceMediatorComponentEvent, ResourceMediatorComponentPairEvent, ResourceMediatorComponentResourceMediatorComponentFunction, ResourceMediatorComponentVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorComponentReference : AtomReference<
        UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent,
        ResourceMediatorComponentPair,
        ResourceMediatorComponentConstant,
        ResourceMediatorComponentVariable,
        ResourceMediatorComponentEvent,
        ResourceMediatorComponentPairEvent,
        ResourceMediatorComponentResourceMediatorComponentFunction,
        ResourceMediatorComponentVariableInstancer>, IEquatable<ResourceMediatorComponentReference>
    {
        public ResourceMediatorComponentReference() : base() { }
        public ResourceMediatorComponentReference(UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent value) : base(value) { }
        public bool Equals(ResourceMediatorComponentReference other) { return base.Equals(other); }
        protected override bool ValueEquals(UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent other)
        {
            throw new NotImplementedException();
        }
    }
}
