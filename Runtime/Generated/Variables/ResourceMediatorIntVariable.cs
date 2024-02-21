using UnityEngine;
using System;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt`. Inherits from `AtomVariable&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt, ResourceMediatorIntPair, ResourceMediatorIntEvent, ResourceMediatorIntPairEvent, ResourceMediatorIntResourceMediatorIntFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/ResourceMediatorInt", fileName = "ResourceMediatorIntVariable")]
    public sealed partial class ResourceMediatorIntVariable : AtomVariable<ResourceMediatorInt, ResourceMediatorIntPair, ResourceMediatorIntEvent, ResourceMediatorIntPairEvent, ResourceMediatorIntResourceMediatorIntFunction>
    {
        protected override bool ValueEquals(ResourceMediatorInt other)
        {
            return other == _value;
        }
    }
}
