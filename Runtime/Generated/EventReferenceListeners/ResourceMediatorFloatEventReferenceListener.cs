using UnityAtomsExtensions.ResourceMediator;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat`. Inherits from `AtomEventReferenceListener&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat, ResourceMediatorFloatEvent, ResourceMediatorFloatEventReference, ResourceMediatorFloatUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ResourceMediatorFloat Event Reference Listener")]
    public sealed class ResourceMediatorFloatEventReferenceListener : AtomEventReferenceListener<
        ResourceMediatorFloat,
        ResourceMediatorFloatEvent,
        ResourceMediatorFloatEventReference,
        ResourceMediatorFloatUnityEvent>
    { }
}
