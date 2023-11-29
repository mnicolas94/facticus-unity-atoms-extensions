using UnityEngine;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `ResourceMediatorGameObjectPair`. Inherits from `AtomEventReferenceListener&lt;ResourceMediatorGameObjectPair, ResourceMediatorGameObjectPairEvent, ResourceMediatorGameObjectPairEventReference, ResourceMediatorGameObjectPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ResourceMediatorGameObjectPair Event Reference Listener")]
    public sealed class ResourceMediatorGameObjectPairEventReferenceListener : AtomEventReferenceListener<
        ResourceMediatorGameObjectPair,
        ResourceMediatorGameObjectPairEvent,
        ResourceMediatorGameObjectPairEventReference,
        ResourceMediatorGameObjectPairUnityEvent>
    { }
}
