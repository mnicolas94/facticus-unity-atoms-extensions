using UnityEngine;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `ResourceMediatorStringPair`. Inherits from `AtomEventReferenceListener&lt;ResourceMediatorStringPair, ResourceMediatorStringPairEvent, ResourceMediatorStringPairEventReference, ResourceMediatorStringPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ResourceMediatorStringPair Event Reference Listener")]
    public sealed class ResourceMediatorStringPairEventReferenceListener : AtomEventReferenceListener<
        ResourceMediatorStringPair,
        ResourceMediatorStringPairEvent,
        ResourceMediatorStringPairEventReference,
        ResourceMediatorStringPairUnityEvent>
    { }
}
