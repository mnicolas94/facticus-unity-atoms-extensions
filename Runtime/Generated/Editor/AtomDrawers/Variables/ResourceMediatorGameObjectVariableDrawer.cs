#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject`. Inherits from `AtomDrawer&lt;ResourceMediatorGameObjectVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ResourceMediatorGameObjectVariable))]
    public class ResourceMediatorGameObjectVariableDrawer : VariableDrawer<ResourceMediatorGameObjectVariable> { }
}
#endif
