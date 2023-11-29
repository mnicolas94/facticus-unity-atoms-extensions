using UnityEngine;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent`. Inherits from `AtomEventReferenceListener&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent, ResourceMediatorComponentEvent, ResourceMediatorComponentEventReference, ResourceMediatorComponentUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ResourceMediatorComponent Event Reference Listener")]
    public sealed class ResourceMediatorComponentEventReferenceListener : AtomEventReferenceListener<
        UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent,
        ResourceMediatorComponentEvent,
        ResourceMediatorComponentEventReference,
        ResourceMediatorComponentUnityEvent>
    { }
}
