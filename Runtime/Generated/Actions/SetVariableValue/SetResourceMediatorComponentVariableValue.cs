using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent`. Inherits from `SetVariableValue&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent, ResourceMediatorComponentPair, ResourceMediatorComponentVariable, ResourceMediatorComponentConstant, ResourceMediatorComponentReference, ResourceMediatorComponentEvent, ResourceMediatorComponentPairEvent, ResourceMediatorComponentVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/ResourceMediatorComponent", fileName = "SetResourceMediatorComponentVariableValue")]
    public sealed class SetResourceMediatorComponentVariableValue : SetVariableValue<
        UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent,
        ResourceMediatorComponentPair,
        ResourceMediatorComponentVariable,
        ResourceMediatorComponentConstant,
        ResourceMediatorComponentReference,
        ResourceMediatorComponentEvent,
        ResourceMediatorComponentPairEvent,
        ResourceMediatorComponentResourceMediatorComponentFunction,
        ResourceMediatorComponentVariableInstancer>
    { }
}
