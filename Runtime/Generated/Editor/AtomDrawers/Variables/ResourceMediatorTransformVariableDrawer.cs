#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform`. Inherits from `AtomDrawer&lt;ResourceMediatorTransformVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ResourceMediatorTransformVariable))]
    public class ResourceMediatorTransformVariableDrawer : VariableDrawer<ResourceMediatorTransformVariable> { }
}
#endif
