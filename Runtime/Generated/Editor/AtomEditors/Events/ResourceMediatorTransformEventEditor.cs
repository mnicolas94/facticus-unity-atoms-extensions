#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform`. Inherits from `AtomEventEditor&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform, ResourceMediatorTransformEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ResourceMediatorTransformEvent))]
    public sealed class ResourceMediatorTransformEventEditor : AtomEventEditor<ResourceMediatorTransform, ResourceMediatorTransformEvent> { }
}
#endif
