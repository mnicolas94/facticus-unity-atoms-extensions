using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat`. Inherits from `SetVariableValue&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat, ResourceMediatorFloatPair, ResourceMediatorFloatVariable, ResourceMediatorFloatConstant, ResourceMediatorFloatReference, ResourceMediatorFloatEvent, ResourceMediatorFloatPairEvent, ResourceMediatorFloatVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/ResourceMediatorFloat", fileName = "SetResourceMediatorFloatVariableValue")]
    public sealed class SetResourceMediatorFloatVariableValue : SetVariableValue<
        UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat,
        ResourceMediatorFloatPair,
        ResourceMediatorFloatVariable,
        ResourceMediatorFloatConstant,
        ResourceMediatorFloatReference,
        ResourceMediatorFloatEvent,
        ResourceMediatorFloatPairEvent,
        ResourceMediatorFloatResourceMediatorFloatFunction,
        ResourceMediatorFloatVariableInstancer>
    { }
}
