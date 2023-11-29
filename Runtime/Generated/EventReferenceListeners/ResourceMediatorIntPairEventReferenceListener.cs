using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `ResourceMediatorIntPair`. Inherits from `AtomEventReferenceListener&lt;ResourceMediatorIntPair, ResourceMediatorIntPairEvent, ResourceMediatorIntPairEventReference, ResourceMediatorIntPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ResourceMediatorIntPair Event Reference Listener")]
    public sealed class ResourceMediatorIntPairEventReferenceListener : AtomEventReferenceListener<
        ResourceMediatorIntPair,
        ResourceMediatorIntPairEvent,
        ResourceMediatorIntPairEventReference,
        ResourceMediatorIntPairUnityEvent>
    { }
}
