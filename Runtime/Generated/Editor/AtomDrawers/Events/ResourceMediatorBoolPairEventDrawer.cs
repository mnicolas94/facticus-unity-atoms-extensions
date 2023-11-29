#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ResourceMediatorBoolPair`. Inherits from `AtomDrawer&lt;ResourceMediatorBoolPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ResourceMediatorBoolPairEvent))]
    public class ResourceMediatorBoolPairEventDrawer : AtomDrawer<ResourceMediatorBoolPairEvent> { }
}
#endif
