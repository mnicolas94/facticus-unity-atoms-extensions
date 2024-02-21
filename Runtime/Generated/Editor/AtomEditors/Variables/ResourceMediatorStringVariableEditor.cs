using UnityEditor;
using UnityAtoms.Editor;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(ResourceMediatorStringVariable))]
    public sealed class
        ResourceMediatorStringVariableEditor : AtomVariableEditor<ResourceMediatorString, ResourceMediatorStringPair>
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            EditorGUILayout.PropertyField(serializedObject.FindProperty("_clearOnEnable"));
            serializedObject.ApplyModifiedProperties();
        }
    }
}
