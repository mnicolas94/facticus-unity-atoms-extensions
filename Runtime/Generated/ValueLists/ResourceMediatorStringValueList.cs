using UnityAtomsExtensions.ResourceMediator;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString`. Inherits from `AtomValueList&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString, ResourceMediatorStringEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/ResourceMediatorString", fileName = "ResourceMediatorStringValueList")]
    public sealed class ResourceMediatorStringValueList : AtomValueList<ResourceMediatorString, ResourceMediatorStringEvent> { }
}
