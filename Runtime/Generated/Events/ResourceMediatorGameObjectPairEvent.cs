using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `ResourceMediatorGameObjectPair`. Inherits from `AtomEvent&lt;ResourceMediatorGameObjectPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/ResourceMediatorGameObjectPair", fileName = "ResourceMediatorGameObjectPairEvent")]
    public sealed class ResourceMediatorGameObjectPairEvent : AtomEvent<ResourceMediatorGameObjectPair>
    {
    }
}
