using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString`. Inherits from `AtomVariableInstancer&lt;ResourceMediatorStringVariable, ResourceMediatorStringPair, UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString, ResourceMediatorStringEvent, ResourceMediatorStringPairEvent, ResourceMediatorStringResourceMediatorStringFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/ResourceMediatorString Variable Instancer")]
    public class ResourceMediatorStringVariableInstancer : AtomVariableInstancer<
        ResourceMediatorStringVariable,
        ResourceMediatorStringPair,
        UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString,
        ResourceMediatorStringEvent,
        ResourceMediatorStringPairEvent,
        ResourceMediatorStringResourceMediatorStringFunction>
    { }
}
