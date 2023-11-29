#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ResourceMediatorStringPair`. Inherits from `AtomEventEditor&lt;ResourceMediatorStringPair, ResourceMediatorStringPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ResourceMediatorStringPairEvent))]
    public sealed class ResourceMediatorStringPairEventEditor : AtomEventEditor<ResourceMediatorStringPair, ResourceMediatorStringPairEvent> { }
}
#endif
