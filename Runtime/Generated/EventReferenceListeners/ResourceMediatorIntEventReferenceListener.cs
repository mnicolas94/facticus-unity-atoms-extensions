using UnityAtomsExtensions.ResourceMediator;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt`. Inherits from `AtomEventReferenceListener&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt, ResourceMediatorIntEvent, ResourceMediatorIntEventReference, ResourceMediatorIntUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ResourceMediatorInt Event Reference Listener")]
    public sealed class ResourceMediatorIntEventReferenceListener : AtomEventReferenceListener<
        ResourceMediatorInt,
        ResourceMediatorIntEvent,
        ResourceMediatorIntEventReference,
        ResourceMediatorIntUnityEvent>
    { }
}
