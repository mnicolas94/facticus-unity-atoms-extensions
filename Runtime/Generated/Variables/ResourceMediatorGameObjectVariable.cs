using UnityEngine;
using System;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject`. Inherits from `AtomVariable&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject, ResourceMediatorGameObjectPair, ResourceMediatorGameObjectEvent, ResourceMediatorGameObjectPairEvent, ResourceMediatorGameObjectResourceMediatorGameObjectFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/ResourceMediatorGameObject", fileName = "ResourceMediatorGameObjectVariable")]
    public sealed class ResourceMediatorGameObjectVariable : AtomVariable<UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject, ResourceMediatorGameObjectPair, ResourceMediatorGameObjectEvent, ResourceMediatorGameObjectPairEvent, ResourceMediatorGameObjectResourceMediatorGameObjectFunction>
    {
        protected override bool ValueEquals(UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject other)
        {
            throw new NotImplementedException();
        }
    }
}
