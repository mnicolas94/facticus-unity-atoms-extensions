using UnityEngine;
using System;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject`. Inherits from `AtomVariable&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject, ResourceMediatorGameObjectPair, ResourceMediatorGameObjectEvent, ResourceMediatorGameObjectPairEvent, ResourceMediatorGameObjectResourceMediatorGameObjectFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/ResourceMediatorGameObject", fileName = "ResourceMediatorGameObjectVariable")]
    public sealed class ResourceMediatorGameObjectVariable : AtomVariable<ResourceMediatorGameObject, ResourceMediatorGameObjectPair, ResourceMediatorGameObjectEvent, ResourceMediatorGameObjectPairEvent, ResourceMediatorGameObjectResourceMediatorGameObjectFunction>
    {
        protected override bool ValueEquals(ResourceMediatorGameObject other)
        {
            return other == _value;
        }
    }
}
