using UnityEditor;
using UnityAtoms.Editor;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(ResourceMediatorBoolVariable))]
    public sealed class ResourceMediatorBoolVariableEditor : AtomVariableEditor<UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool, ResourceMediatorBoolPair> { }
}
