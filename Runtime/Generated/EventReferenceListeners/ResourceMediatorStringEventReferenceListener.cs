using UnityEngine;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString`. Inherits from `AtomEventReferenceListener&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString, ResourceMediatorStringEvent, ResourceMediatorStringEventReference, ResourceMediatorStringUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ResourceMediatorString Event Reference Listener")]
    public sealed class ResourceMediatorStringEventReferenceListener : AtomEventReferenceListener<
        UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString,
        ResourceMediatorStringEvent,
        ResourceMediatorStringEventReference,
        ResourceMediatorStringUnityEvent>
    { }
}
