using UnityEngine;
using System;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent`. Inherits from `AtomVariable&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent, ResourceMediatorComponentPair, ResourceMediatorComponentEvent, ResourceMediatorComponentPairEvent, ResourceMediatorComponentResourceMediatorComponentFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/ResourceMediatorComponent", fileName = "ResourceMediatorComponentVariable")]
    public sealed class ResourceMediatorComponentVariable : AtomVariable<UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent, ResourceMediatorComponentPair, ResourceMediatorComponentEvent, ResourceMediatorComponentPairEvent, ResourceMediatorComponentResourceMediatorComponentFunction>
    {
        protected override bool ValueEquals(UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent other)
        {
            return other == _value;
        }
    }
}