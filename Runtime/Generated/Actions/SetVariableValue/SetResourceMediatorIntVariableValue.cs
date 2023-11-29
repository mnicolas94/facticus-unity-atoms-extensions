using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt`. Inherits from `SetVariableValue&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt, ResourceMediatorIntPair, ResourceMediatorIntVariable, ResourceMediatorIntConstant, ResourceMediatorIntReference, ResourceMediatorIntEvent, ResourceMediatorIntPairEvent, ResourceMediatorIntVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/ResourceMediatorInt", fileName = "SetResourceMediatorIntVariableValue")]
    public sealed class SetResourceMediatorIntVariableValue : SetVariableValue<
        ResourceMediatorInt,
        ResourceMediatorIntPair,
        ResourceMediatorIntVariable,
        ResourceMediatorIntConstant,
        ResourceMediatorIntReference,
        ResourceMediatorIntEvent,
        ResourceMediatorIntPairEvent,
        ResourceMediatorIntResourceMediatorIntFunction,
        ResourceMediatorIntVariableInstancer>
    { }
}
