using System;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform`. Inherits from `AtomReference&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform, ResourceMediatorTransformPair, ResourceMediatorTransformConstant, ResourceMediatorTransformVariable, ResourceMediatorTransformEvent, ResourceMediatorTransformPairEvent, ResourceMediatorTransformResourceMediatorTransformFunction, ResourceMediatorTransformVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorTransformReference : AtomReference<
        UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform,
        ResourceMediatorTransformPair,
        ResourceMediatorTransformConstant,
        ResourceMediatorTransformVariable,
        ResourceMediatorTransformEvent,
        ResourceMediatorTransformPairEvent,
        ResourceMediatorTransformResourceMediatorTransformFunction,
        ResourceMediatorTransformVariableInstancer>, IEquatable<ResourceMediatorTransformReference>
    {
        public ResourceMediatorTransformReference() : base() { }
        public ResourceMediatorTransformReference(UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform value) : base(value) { }
        public bool Equals(ResourceMediatorTransformReference other) { return base.Equals(other); }
        protected override bool ValueEquals(UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform other)
        {
            throw new NotImplementedException();
        }
    }
}
