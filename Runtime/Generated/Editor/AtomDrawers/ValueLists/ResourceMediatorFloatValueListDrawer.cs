#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat`. Inherits from `AtomDrawer&lt;ResourceMediatorFloatValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ResourceMediatorFloatValueList))]
    public class ResourceMediatorFloatValueListDrawer : AtomDrawer<ResourceMediatorFloatValueList> { }
}
#endif
