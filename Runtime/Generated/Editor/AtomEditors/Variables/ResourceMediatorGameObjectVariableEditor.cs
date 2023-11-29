using UnityEditor;
using UnityAtoms.Editor;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(ResourceMediatorGameObjectVariable))]
    public sealed class ResourceMediatorGameObjectVariableEditor : AtomVariableEditor<ResourceMediatorGameObject, ResourceMediatorGameObjectPair> { }
}
