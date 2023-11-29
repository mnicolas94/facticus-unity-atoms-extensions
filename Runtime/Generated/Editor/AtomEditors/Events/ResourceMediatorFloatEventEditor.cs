#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat`. Inherits from `AtomEventEditor&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat, ResourceMediatorFloatEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ResourceMediatorFloatEvent))]
    public sealed class ResourceMediatorFloatEventEditor : AtomEventEditor<UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat, ResourceMediatorFloatEvent> { }
}
#endif
