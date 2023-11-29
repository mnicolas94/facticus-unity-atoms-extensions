using UnityAtomsExtensions.ResourceMediator;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform`. Inherits from `AtomEventReferenceListener&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform, ResourceMediatorTransformEvent, ResourceMediatorTransformEventReference, ResourceMediatorTransformUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ResourceMediatorTransform Event Reference Listener")]
    public sealed class ResourceMediatorTransformEventReferenceListener : AtomEventReferenceListener<
        ResourceMediatorTransform,
        ResourceMediatorTransformEvent,
        ResourceMediatorTransformEventReference,
        ResourceMediatorTransformUnityEvent>
    { }
}
