using UnityEngine;
using System;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString`. Inherits from `AtomVariable&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString, ResourceMediatorStringPair, ResourceMediatorStringEvent, ResourceMediatorStringPairEvent, ResourceMediatorStringResourceMediatorStringFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/ResourceMediatorString", fileName = "ResourceMediatorStringVariable")]
    public sealed class ResourceMediatorStringVariable : AtomVariable<UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString, ResourceMediatorStringPair, ResourceMediatorStringEvent, ResourceMediatorStringPairEvent, ResourceMediatorStringResourceMediatorStringFunction>
    {
        protected override bool ValueEquals(UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString other)
        {
            throw new NotImplementedException();
        }
    }
}
