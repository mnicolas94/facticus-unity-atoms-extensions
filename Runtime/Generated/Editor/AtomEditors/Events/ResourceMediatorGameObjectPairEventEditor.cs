#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ResourceMediatorGameObjectPair`. Inherits from `AtomEventEditor&lt;ResourceMediatorGameObjectPair, ResourceMediatorGameObjectPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ResourceMediatorGameObjectPairEvent))]
    public sealed class ResourceMediatorGameObjectPairEventEditor : AtomEventEditor<ResourceMediatorGameObjectPair, ResourceMediatorGameObjectPairEvent> { }
}
#endif
