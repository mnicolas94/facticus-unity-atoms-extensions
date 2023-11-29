using UnityEngine;
using System;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat`. Inherits from `AtomVariable&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat, ResourceMediatorFloatPair, ResourceMediatorFloatEvent, ResourceMediatorFloatPairEvent, ResourceMediatorFloatResourceMediatorFloatFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/ResourceMediatorFloat", fileName = "ResourceMediatorFloatVariable")]
    public sealed class ResourceMediatorFloatVariable : AtomVariable<UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat, ResourceMediatorFloatPair, ResourceMediatorFloatEvent, ResourceMediatorFloatPairEvent, ResourceMediatorFloatResourceMediatorFloatFunction>
    {
        protected override bool ValueEquals(UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat other)
        {
            throw new NotImplementedException();
        }
    }
}
