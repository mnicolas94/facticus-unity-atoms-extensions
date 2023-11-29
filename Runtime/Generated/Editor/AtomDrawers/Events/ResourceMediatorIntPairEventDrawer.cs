#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ResourceMediatorIntPair`. Inherits from `AtomDrawer&lt;ResourceMediatorIntPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ResourceMediatorIntPairEvent))]
    public class ResourceMediatorIntPairEventDrawer : AtomDrawer<ResourceMediatorIntPairEvent> { }
}
#endif
