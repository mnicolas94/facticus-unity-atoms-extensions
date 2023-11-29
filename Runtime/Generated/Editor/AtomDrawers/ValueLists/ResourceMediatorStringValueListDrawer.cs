#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString`. Inherits from `AtomDrawer&lt;ResourceMediatorStringValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ResourceMediatorStringValueList))]
    public class ResourceMediatorStringValueListDrawer : AtomDrawer<ResourceMediatorStringValueList> { }
}
#endif
