#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `TestObjectPair`. Inherits from `AtomDrawer&lt;TestObjectPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(TestObjectPairEvent))]
    public class TestObjectPairEventDrawer : AtomDrawer<TestObjectPairEvent> { }
}
#endif
