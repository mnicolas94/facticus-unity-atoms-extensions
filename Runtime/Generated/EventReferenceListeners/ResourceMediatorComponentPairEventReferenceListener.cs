using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `ResourceMediatorComponentPair`. Inherits from `AtomEventReferenceListener&lt;ResourceMediatorComponentPair, ResourceMediatorComponentPairEvent, ResourceMediatorComponentPairEventReference, ResourceMediatorComponentPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ResourceMediatorComponentPair Event Reference Listener")]
    public sealed class ResourceMediatorComponentPairEventReferenceListener : AtomEventReferenceListener<
        ResourceMediatorComponentPair,
        ResourceMediatorComponentPairEvent,
        ResourceMediatorComponentPairEventReference,
        ResourceMediatorComponentPairUnityEvent>
    { }
}
