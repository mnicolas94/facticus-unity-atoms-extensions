using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `ResourceMediatorComponentPair`. Inherits from `AtomEvent&lt;ResourceMediatorComponentPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/ResourceMediatorComponentPair", fileName = "ResourceMediatorComponentPairEvent")]
    public sealed class ResourceMediatorComponentPairEvent : AtomEvent<ResourceMediatorComponentPair>
    {
    }
}
