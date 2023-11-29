using UnityEditor;
using UnityAtoms.Editor;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(ResourceMediatorTransformVariable))]
    public sealed class ResourceMediatorTransformVariableEditor : AtomVariableEditor<ResourceMediatorTransform, ResourceMediatorTransformPair> { }
}
