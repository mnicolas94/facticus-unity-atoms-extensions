#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool`. Inherits from `AtomDrawer&lt;ResourceMediatorBoolConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ResourceMediatorBoolConstant))]
    public class ResourceMediatorBoolConstantDrawer : VariableDrawer<ResourceMediatorBoolConstant> { }
}
#endif
