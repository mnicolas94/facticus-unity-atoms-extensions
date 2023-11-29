using System;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat`. Inherits from `AtomReference&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat, ResourceMediatorFloatPair, ResourceMediatorFloatConstant, ResourceMediatorFloatVariable, ResourceMediatorFloatEvent, ResourceMediatorFloatPairEvent, ResourceMediatorFloatResourceMediatorFloatFunction, ResourceMediatorFloatVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorFloatReference : AtomReference<
        ResourceMediatorFloat,
        ResourceMediatorFloatPair,
        ResourceMediatorFloatConstant,
        ResourceMediatorFloatVariable,
        ResourceMediatorFloatEvent,
        ResourceMediatorFloatPairEvent,
        ResourceMediatorFloatResourceMediatorFloatFunction,
        ResourceMediatorFloatVariableInstancer>, IEquatable<ResourceMediatorFloatReference>
    {
        public ResourceMediatorFloatReference() : base() { }
        public ResourceMediatorFloatReference(ResourceMediatorFloat value) : base(value) { }
        public bool Equals(ResourceMediatorFloatReference other) { return base.Equals(other); }
        protected override bool ValueEquals(ResourceMediatorFloat other)
        {
            throw new NotImplementedException();
        }
    }
}
