using UnityEditor;
using UnityAtoms.Editor;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(ResourceMediatorBoolVariable))]
    public sealed class
        ResourceMediatorBoolVariableEditor : AtomVariableEditor<ResourceMediatorBool, ResourceMediatorBoolPair>
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            EditorGUILayout.PropertyField(serializedObject.FindProperty("_clearOnEnable"));
            serializedObject.ApplyModifiedProperties();
        }
    }
}
