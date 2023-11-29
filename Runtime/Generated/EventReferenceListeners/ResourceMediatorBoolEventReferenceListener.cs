using UnityEngine;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool`. Inherits from `AtomEventReferenceListener&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool, ResourceMediatorBoolEvent, ResourceMediatorBoolEventReference, ResourceMediatorBoolUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ResourceMediatorBool Event Reference Listener")]
    public sealed class ResourceMediatorBoolEventReferenceListener : AtomEventReferenceListener<
        UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool,
        ResourceMediatorBoolEvent,
        ResourceMediatorBoolEventReference,
        ResourceMediatorBoolUnityEvent>
    { }
}
