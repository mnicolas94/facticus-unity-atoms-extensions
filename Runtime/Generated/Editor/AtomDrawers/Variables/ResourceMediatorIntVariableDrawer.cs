#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt`. Inherits from `AtomDrawer&lt;ResourceMediatorIntVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ResourceMediatorIntVariable))]
    public class ResourceMediatorIntVariableDrawer : VariableDrawer<ResourceMediatorIntVariable> { }
}
#endif
