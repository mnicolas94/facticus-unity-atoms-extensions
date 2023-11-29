#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ResourceMediatorFloatPair`. Inherits from `AtomEventEditor&lt;ResourceMediatorFloatPair, ResourceMediatorFloatPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ResourceMediatorFloatPairEvent))]
    public sealed class ResourceMediatorFloatPairEventEditor : AtomEventEditor<ResourceMediatorFloatPair, ResourceMediatorFloatPairEvent> { }
}
#endif
