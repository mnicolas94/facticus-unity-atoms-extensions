using UnityEditor;
using UnityAtoms.Editor;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(ResourceMediatorFloatVariable))]
    public sealed class ResourceMediatorFloatVariableEditor : AtomVariableEditor<ResourceMediatorFloat, ResourceMediatorFloatPair> { }
}
