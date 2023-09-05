#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `UnityAtomsExtensions.Samples.TestObject`. Inherits from `AtomDrawer&lt;TestObjectVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(TestObjectVariable))]
    public class TestObjectVariableDrawer : VariableDrawer<TestObjectVariable> { }
}
#endif
