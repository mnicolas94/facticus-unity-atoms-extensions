#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ResourceMediatorBoolPair`. Inherits from `AtomEventEditor&lt;ResourceMediatorBoolPair, ResourceMediatorBoolPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ResourceMediatorBoolPairEvent))]
    public sealed class ResourceMediatorBoolPairEventEditor : AtomEventEditor<ResourceMediatorBoolPair, ResourceMediatorBoolPairEvent> { }
}
#endif