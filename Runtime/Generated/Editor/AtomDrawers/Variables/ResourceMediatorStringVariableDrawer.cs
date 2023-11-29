#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString`. Inherits from `AtomDrawer&lt;ResourceMediatorStringVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ResourceMediatorStringVariable))]
    public class ResourceMediatorStringVariableDrawer : VariableDrawer<ResourceMediatorStringVariable> { }
}
#endif
