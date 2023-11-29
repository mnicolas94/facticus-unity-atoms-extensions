using System;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool`. Inherits from `AtomReference&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool, ResourceMediatorBoolPair, ResourceMediatorBoolConstant, ResourceMediatorBoolVariable, ResourceMediatorBoolEvent, ResourceMediatorBoolPairEvent, ResourceMediatorBoolResourceMediatorBoolFunction, ResourceMediatorBoolVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorBoolReference : AtomReference<
        ResourceMediatorBool,
        ResourceMediatorBoolPair,
        ResourceMediatorBoolConstant,
        ResourceMediatorBoolVariable,
        ResourceMediatorBoolEvent,
        ResourceMediatorBoolPairEvent,
        ResourceMediatorBoolResourceMediatorBoolFunction,
        ResourceMediatorBoolVariableInstancer>, IEquatable<ResourceMediatorBoolReference>
    {
        public ResourceMediatorBoolReference() : base() { }
        public ResourceMediatorBoolReference(ResourceMediatorBool value) : base(value) { }
        public bool Equals(ResourceMediatorBoolReference other) { return base.Equals(other); }
        protected override bool ValueEquals(ResourceMediatorBool other)
        {
            throw new NotImplementedException();
        }
    }
}
