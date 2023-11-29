using UnityEngine;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `ResourceMediatorStringPair`. Inherits from `AtomEvent&lt;ResourceMediatorStringPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/ResourceMediatorStringPair", fileName = "ResourceMediatorStringPairEvent")]
    public sealed class ResourceMediatorStringPairEvent : AtomEvent<ResourceMediatorStringPair>
    {
    }
}
