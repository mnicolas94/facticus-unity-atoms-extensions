using UnityEditor;
using UnityAtoms.Editor;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(ResourceMediatorStringVariable))]
    public sealed class ResourceMediatorStringVariableEditor : AtomVariableEditor<UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString, ResourceMediatorStringPair> { }
}
