#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `UnityAtomsExtensions.Samples.TestObject`. Inherits from `AtomDrawer&lt;TestObjectEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(TestObjectEvent))]
    public class TestObjectEventDrawer : AtomDrawer<TestObjectEvent> { }
}
#endif
