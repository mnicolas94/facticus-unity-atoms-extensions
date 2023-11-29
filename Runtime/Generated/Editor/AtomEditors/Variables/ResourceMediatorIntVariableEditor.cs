using UnityEditor;
using UnityAtoms.Editor;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(ResourceMediatorIntVariable))]
    public sealed class ResourceMediatorIntVariableEditor : AtomVariableEditor<UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt, ResourceMediatorIntPair> { }
}
