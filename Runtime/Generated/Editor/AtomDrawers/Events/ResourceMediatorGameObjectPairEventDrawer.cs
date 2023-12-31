#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ResourceMediatorGameObjectPair`. Inherits from `AtomDrawer&lt;ResourceMediatorGameObjectPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ResourceMediatorGameObjectPairEvent))]
    public class ResourceMediatorGameObjectPairEventDrawer : AtomDrawer<ResourceMediatorGameObjectPairEvent> { }
}
#endif
