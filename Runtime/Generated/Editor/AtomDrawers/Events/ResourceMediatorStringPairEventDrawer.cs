#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ResourceMediatorStringPair`. Inherits from `AtomDrawer&lt;ResourceMediatorStringPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ResourceMediatorStringPairEvent))]
    public class ResourceMediatorStringPairEventDrawer : AtomDrawer<ResourceMediatorStringPairEvent> { }
}
#endif
