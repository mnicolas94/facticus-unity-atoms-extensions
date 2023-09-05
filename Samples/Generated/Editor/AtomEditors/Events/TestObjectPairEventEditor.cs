#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityAtomsExtensions.Samples;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `TestObjectPair`. Inherits from `AtomEventEditor&lt;TestObjectPair, TestObjectPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(TestObjectPairEvent))]
    public sealed class TestObjectPairEventEditor : AtomEventEditor<TestObjectPair, TestObjectPairEvent> { }
}
#endif
