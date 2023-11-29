using UnityEngine;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `ResourceMediatorFloatPair`. Inherits from `AtomEvent&lt;ResourceMediatorFloatPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/ResourceMediatorFloatPair", fileName = "ResourceMediatorFloatPairEvent")]
    public sealed class ResourceMediatorFloatPairEvent : AtomEvent<ResourceMediatorFloatPair>
    {
    }
}
