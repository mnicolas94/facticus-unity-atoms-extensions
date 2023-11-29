using UnityEngine;
using System;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool`. Inherits from `AtomVariable&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool, ResourceMediatorBoolPair, ResourceMediatorBoolEvent, ResourceMediatorBoolPairEvent, ResourceMediatorBoolResourceMediatorBoolFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/ResourceMediatorBool", fileName = "ResourceMediatorBoolVariable")]
    public sealed class ResourceMediatorBoolVariable : AtomVariable<UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool, ResourceMediatorBoolPair, ResourceMediatorBoolEvent, ResourceMediatorBoolPairEvent, ResourceMediatorBoolResourceMediatorBoolFunction>
    {
        protected override bool ValueEquals(UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool other)
        {
            throw new NotImplementedException();
        }
    }
}
