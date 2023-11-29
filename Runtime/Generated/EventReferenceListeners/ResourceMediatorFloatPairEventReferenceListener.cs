using UnityEngine;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `ResourceMediatorFloatPair`. Inherits from `AtomEventReferenceListener&lt;ResourceMediatorFloatPair, ResourceMediatorFloatPairEvent, ResourceMediatorFloatPairEventReference, ResourceMediatorFloatPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ResourceMediatorFloatPair Event Reference Listener")]
    public sealed class ResourceMediatorFloatPairEventReferenceListener : AtomEventReferenceListener<
        ResourceMediatorFloatPair,
        ResourceMediatorFloatPairEvent,
        ResourceMediatorFloatPairEventReference,
        ResourceMediatorFloatPairUnityEvent>
    { }
}
