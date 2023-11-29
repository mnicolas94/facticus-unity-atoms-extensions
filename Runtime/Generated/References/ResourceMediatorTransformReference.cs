using System;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform`. Inherits from `AtomReference&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform, ResourceMediatorTransformPair, ResourceMediatorTransformConstant, ResourceMediatorTransformVariable, ResourceMediatorTransformEvent, ResourceMediatorTransformPairEvent, ResourceMediatorTransformResourceMediatorTransformFunction, ResourceMediatorTransformVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorTransformReference : AtomReference<
        ResourceMediatorTransform,
        ResourceMediatorTransformPair,
        ResourceMediatorTransformConstant,
        ResourceMediatorTransformVariable,
        ResourceMediatorTransformEvent,
        ResourceMediatorTransformPairEvent,
        ResourceMediatorTransformResourceMediatorTransformFunction,
        ResourceMediatorTransformVariableInstancer>, IEquatable<ResourceMediatorTransformReference>
    {
        public ResourceMediatorTransformReference() : base() { }
        public ResourceMediatorTransformReference(ResourceMediatorTransform value) : base(value) { }
        public bool Equals(ResourceMediatorTransformReference other) { return base.Equals(other); }
        protected override bool ValueEquals(ResourceMediatorTransform other)
        {
            throw new NotImplementedException();
        }
    }
}
