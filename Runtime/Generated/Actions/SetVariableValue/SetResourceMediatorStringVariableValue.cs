using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString`. Inherits from `SetVariableValue&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString, ResourceMediatorStringPair, ResourceMediatorStringVariable, ResourceMediatorStringConstant, ResourceMediatorStringReference, ResourceMediatorStringEvent, ResourceMediatorStringPairEvent, ResourceMediatorStringVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/ResourceMediatorString", fileName = "SetResourceMediatorStringVariableValue")]
    public sealed class SetResourceMediatorStringVariableValue : SetVariableValue<
        UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString,
        ResourceMediatorStringPair,
        ResourceMediatorStringVariable,
        ResourceMediatorStringConstant,
        ResourceMediatorStringReference,
        ResourceMediatorStringEvent,
        ResourceMediatorStringPairEvent,
        ResourceMediatorStringResourceMediatorStringFunction,
        ResourceMediatorStringVariableInstancer>
    { }
}
