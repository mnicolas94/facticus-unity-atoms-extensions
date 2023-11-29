using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject`. Inherits from `AtomVariableInstancer&lt;ResourceMediatorGameObjectVariable, ResourceMediatorGameObjectPair, UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject, ResourceMediatorGameObjectEvent, ResourceMediatorGameObjectPairEvent, ResourceMediatorGameObjectResourceMediatorGameObjectFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/ResourceMediatorGameObject Variable Instancer")]
    public class ResourceMediatorGameObjectVariableInstancer : AtomVariableInstancer<
        ResourceMediatorGameObjectVariable,
        ResourceMediatorGameObjectPair,
        ResourceMediatorGameObject,
        ResourceMediatorGameObjectEvent,
        ResourceMediatorGameObjectPairEvent,
        ResourceMediatorGameObjectResourceMediatorGameObjectFunction>
    { }
}
