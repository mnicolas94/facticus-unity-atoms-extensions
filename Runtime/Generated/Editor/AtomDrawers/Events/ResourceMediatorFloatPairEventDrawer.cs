#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ResourceMediatorFloatPair`. Inherits from `AtomDrawer&lt;ResourceMediatorFloatPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ResourceMediatorFloatPairEvent))]
    public class ResourceMediatorFloatPairEventDrawer : AtomDrawer<ResourceMediatorFloatPairEvent> { }
}
#endif
