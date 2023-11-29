using UnityEngine;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject`. Inherits from `AtomEventReferenceListener&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject, ResourceMediatorGameObjectEvent, ResourceMediatorGameObjectEventReference, ResourceMediatorGameObjectUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ResourceMediatorGameObject Event Reference Listener")]
    public sealed class ResourceMediatorGameObjectEventReferenceListener : AtomEventReferenceListener<
        UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject,
        ResourceMediatorGameObjectEvent,
        ResourceMediatorGameObjectEventReference,
        ResourceMediatorGameObjectUnityEvent>
    { }
}
