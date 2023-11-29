using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool`. Inherits from `SetVariableValue&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool, ResourceMediatorBoolPair, ResourceMediatorBoolVariable, ResourceMediatorBoolConstant, ResourceMediatorBoolReference, ResourceMediatorBoolEvent, ResourceMediatorBoolPairEvent, ResourceMediatorBoolVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/ResourceMediatorBool", fileName = "SetResourceMediatorBoolVariableValue")]
    public sealed class SetResourceMediatorBoolVariableValue : SetVariableValue<
        ResourceMediatorBool,
        ResourceMediatorBoolPair,
        ResourceMediatorBoolVariable,
        ResourceMediatorBoolConstant,
        ResourceMediatorBoolReference,
        ResourceMediatorBoolEvent,
        ResourceMediatorBoolPairEvent,
        ResourceMediatorBoolResourceMediatorBoolFunction,
        ResourceMediatorBoolVariableInstancer>
    { }
}
