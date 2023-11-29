using UnityEditor;
using UnityAtoms.Editor;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(ResourceMediatorComponentVariable))]
    public sealed class ResourceMediatorComponentVariableEditor : AtomVariableEditor<ResourceMediatorComponent, ResourceMediatorComponentPair> { }
}
