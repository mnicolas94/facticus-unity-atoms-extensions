using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform`. Inherits from `SetVariableValue&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform, ResourceMediatorTransformPair, ResourceMediatorTransformVariable, ResourceMediatorTransformConstant, ResourceMediatorTransformReference, ResourceMediatorTransformEvent, ResourceMediatorTransformPairEvent, ResourceMediatorTransformVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/ResourceMediatorTransform", fileName = "SetResourceMediatorTransformVariableValue")]
    public sealed class SetResourceMediatorTransformVariableValue : SetVariableValue<
        UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform,
        ResourceMediatorTransformPair,
        ResourceMediatorTransformVariable,
        ResourceMediatorTransformConstant,
        ResourceMediatorTransformReference,
        ResourceMediatorTransformEvent,
        ResourceMediatorTransformPairEvent,
        ResourceMediatorTransformResourceMediatorTransformFunction,
        ResourceMediatorTransformVariableInstancer>
    { }
}
