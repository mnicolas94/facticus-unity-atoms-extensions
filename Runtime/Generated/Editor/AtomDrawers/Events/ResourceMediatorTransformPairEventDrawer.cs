#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ResourceMediatorTransformPair`. Inherits from `AtomDrawer&lt;ResourceMediatorTransformPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ResourceMediatorTransformPairEvent))]
    public class ResourceMediatorTransformPairEventDrawer : AtomDrawer<ResourceMediatorTransformPairEvent> { }
}
#endif
