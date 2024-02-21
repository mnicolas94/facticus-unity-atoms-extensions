using UnityEngine;
using System;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool`. Inherits from `AtomVariable&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool, ResourceMediatorBoolPair, ResourceMediatorBoolEvent, ResourceMediatorBoolPairEvent, ResourceMediatorBoolResourceMediatorBoolFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/ResourceMediatorBool", fileName = "ResourceMediatorBoolVariable")]
    public sealed partial class ResourceMediatorBoolVariable : AtomVariable<ResourceMediatorBool, ResourceMediatorBoolPair, ResourceMediatorBoolEvent, ResourceMediatorBoolPairEvent, ResourceMediatorBoolResourceMediatorBoolFunction>
    {
        protected override bool ValueEquals(ResourceMediatorBool other)
        {
            return other == _value;
        }
    }
}
