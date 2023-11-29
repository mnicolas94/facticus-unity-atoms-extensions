using System;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject`. Inherits from `AtomReference&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject, ResourceMediatorGameObjectPair, ResourceMediatorGameObjectConstant, ResourceMediatorGameObjectVariable, ResourceMediatorGameObjectEvent, ResourceMediatorGameObjectPairEvent, ResourceMediatorGameObjectResourceMediatorGameObjectFunction, ResourceMediatorGameObjectVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorGameObjectReference : AtomReference<
        ResourceMediatorGameObject,
        ResourceMediatorGameObjectPair,
        ResourceMediatorGameObjectConstant,
        ResourceMediatorGameObjectVariable,
        ResourceMediatorGameObjectEvent,
        ResourceMediatorGameObjectPairEvent,
        ResourceMediatorGameObjectResourceMediatorGameObjectFunction,
        ResourceMediatorGameObjectVariableInstancer>, IEquatable<ResourceMediatorGameObjectReference>
    {
        public ResourceMediatorGameObjectReference() : base() { }
        public ResourceMediatorGameObjectReference(ResourceMediatorGameObject value) : base(value) { }
        public bool Equals(ResourceMediatorGameObjectReference other) { return base.Equals(other); }
        protected override bool ValueEquals(ResourceMediatorGameObject other)
        {
            throw new NotImplementedException();
        }
    }
}
