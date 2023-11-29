using UnityEditor;
using UnityAtoms.Editor;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(ResourceMediatorFloatVariable))]
    public sealed class ResourceMediatorFloatVariableEditor : AtomVariableEditor<UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat, ResourceMediatorFloatPair> { }
}
