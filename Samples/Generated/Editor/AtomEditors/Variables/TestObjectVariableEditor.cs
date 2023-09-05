using UnityEditor;
using UnityAtoms.Editor;
using UnityAtomsExtensions.Samples;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `UnityAtomsExtensions.Samples.TestObject`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(TestObjectVariable))]
    public sealed class TestObjectVariableEditor : AtomVariableEditor<UnityAtomsExtensions.Samples.TestObject, TestObjectPair> { }
}
