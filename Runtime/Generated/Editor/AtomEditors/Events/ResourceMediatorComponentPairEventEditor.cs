#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ResourceMediatorComponentPair`. Inherits from `AtomEventEditor&lt;ResourceMediatorComponentPair, ResourceMediatorComponentPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ResourceMediatorComponentPairEvent))]
    public sealed class ResourceMediatorComponentPairEventEditor : AtomEventEditor<ResourceMediatorComponentPair, ResourceMediatorComponentPairEvent> { }
}
#endif
