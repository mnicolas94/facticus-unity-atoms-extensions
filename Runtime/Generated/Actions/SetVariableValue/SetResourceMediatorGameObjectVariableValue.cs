using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject`. Inherits from `SetVariableValue&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject, ResourceMediatorGameObjectPair, ResourceMediatorGameObjectVariable, ResourceMediatorGameObjectConstant, ResourceMediatorGameObjectReference, ResourceMediatorGameObjectEvent, ResourceMediatorGameObjectPairEvent, ResourceMediatorGameObjectVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/ResourceMediatorGameObject", fileName = "SetResourceMediatorGameObjectVariableValue")]
    public sealed class SetResourceMediatorGameObjectVariableValue : SetVariableValue<
        UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject,
        ResourceMediatorGameObjectPair,
        ResourceMediatorGameObjectVariable,
        ResourceMediatorGameObjectConstant,
        ResourceMediatorGameObjectReference,
        ResourceMediatorGameObjectEvent,
        ResourceMediatorGameObjectPairEvent,
        ResourceMediatorGameObjectResourceMediatorGameObjectFunction,
        ResourceMediatorGameObjectVariableInstancer>
    { }
}
