#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityAtomsExtensions.Samples;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `UnityAtomsExtensions.Samples.TestObject`. Inherits from `AtomEventEditor&lt;UnityAtomsExtensions.Samples.TestObject, TestObjectEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(TestObjectEvent))]
    public sealed class TestObjectEventEditor : AtomEventEditor<UnityAtomsExtensions.Samples.TestObject, TestObjectEvent> { }
}
#endif
