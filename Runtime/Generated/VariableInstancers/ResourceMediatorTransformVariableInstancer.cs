using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform`. Inherits from `AtomVariableInstancer&lt;ResourceMediatorTransformVariable, ResourceMediatorTransformPair, UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform, ResourceMediatorTransformEvent, ResourceMediatorTransformPairEvent, ResourceMediatorTransformResourceMediatorTransformFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/ResourceMediatorTransform Variable Instancer")]
    public class ResourceMediatorTransformVariableInstancer : AtomVariableInstancer<
        ResourceMediatorTransformVariable,
        ResourceMediatorTransformPair,
        ResourceMediatorTransform,
        ResourceMediatorTransformEvent,
        ResourceMediatorTransformPairEvent,
        ResourceMediatorTransformResourceMediatorTransformFunction>
    { }
}
