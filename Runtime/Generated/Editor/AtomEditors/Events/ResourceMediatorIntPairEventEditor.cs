#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ResourceMediatorIntPair`. Inherits from `AtomEventEditor&lt;ResourceMediatorIntPair, ResourceMediatorIntPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ResourceMediatorIntPairEvent))]
    public sealed class ResourceMediatorIntPairEventEditor : AtomEventEditor<ResourceMediatorIntPair, ResourceMediatorIntPairEvent> { }
}
#endif
