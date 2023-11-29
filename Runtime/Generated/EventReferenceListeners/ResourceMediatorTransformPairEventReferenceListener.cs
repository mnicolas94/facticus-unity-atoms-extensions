using UnityEngine;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `ResourceMediatorTransformPair`. Inherits from `AtomEventReferenceListener&lt;ResourceMediatorTransformPair, ResourceMediatorTransformPairEvent, ResourceMediatorTransformPairEventReference, ResourceMediatorTransformPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ResourceMediatorTransformPair Event Reference Listener")]
    public sealed class ResourceMediatorTransformPairEventReferenceListener : AtomEventReferenceListener<
        ResourceMediatorTransformPair,
        ResourceMediatorTransformPairEvent,
        ResourceMediatorTransformPairEventReference,
        ResourceMediatorTransformPairUnityEvent>
    { }
}
