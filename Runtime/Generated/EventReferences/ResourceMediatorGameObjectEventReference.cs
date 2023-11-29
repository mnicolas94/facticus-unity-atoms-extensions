using System;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject`. Inherits from `AtomEventReference&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject, ResourceMediatorGameObjectVariable, ResourceMediatorGameObjectEvent, ResourceMediatorGameObjectVariableInstancer, ResourceMediatorGameObjectEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorGameObjectEventReference : AtomEventReference<
        UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject,
        ResourceMediatorGameObjectVariable,
        ResourceMediatorGameObjectEvent,
        ResourceMediatorGameObjectVariableInstancer,
        ResourceMediatorGameObjectEventInstancer>, IGetEvent 
    { }
}
