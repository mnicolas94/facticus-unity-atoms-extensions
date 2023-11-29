#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ResourceMediatorTransformPair`. Inherits from `AtomEventEditor&lt;ResourceMediatorTransformPair, ResourceMediatorTransformPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ResourceMediatorTransformPairEvent))]
    public sealed class ResourceMediatorTransformPairEventEditor : AtomEventEditor<ResourceMediatorTransformPair, ResourceMediatorTransformPairEvent> { }
}
#endif
