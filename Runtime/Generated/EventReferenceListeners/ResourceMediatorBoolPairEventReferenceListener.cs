using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `ResourceMediatorBoolPair`. Inherits from `AtomEventReferenceListener&lt;ResourceMediatorBoolPair, ResourceMediatorBoolPairEvent, ResourceMediatorBoolPairEventReference, ResourceMediatorBoolPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ResourceMediatorBoolPair Event Reference Listener")]
    public sealed class ResourceMediatorBoolPairEventReferenceListener : AtomEventReferenceListener<
        ResourceMediatorBoolPair,
        ResourceMediatorBoolPairEvent,
        ResourceMediatorBoolPairEventReference,
        ResourceMediatorBoolPairUnityEvent>
    { }
}
