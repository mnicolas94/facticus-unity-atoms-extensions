using UnityEngine;
using System;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform`. Inherits from `AtomVariable&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform, ResourceMediatorTransformPair, ResourceMediatorTransformEvent, ResourceMediatorTransformPairEvent, ResourceMediatorTransformResourceMediatorTransformFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/ResourceMediatorTransform", fileName = "ResourceMediatorTransformVariable")]
    public sealed class ResourceMediatorTransformVariable : AtomVariable<ResourceMediatorTransform, ResourceMediatorTransformPair, ResourceMediatorTransformEvent, ResourceMediatorTransformPairEvent, ResourceMediatorTransformResourceMediatorTransformFunction>
    {
        protected override bool ValueEquals(ResourceMediatorTransform other)
        {
            return other == _value;
        }
    }
}
