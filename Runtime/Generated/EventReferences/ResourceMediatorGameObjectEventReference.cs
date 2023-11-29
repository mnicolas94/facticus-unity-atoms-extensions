using System;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject`. Inherits from `AtomEventReference&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorGameObject, ResourceMediatorGameObjectVariable, ResourceMediatorGameObjectEvent, ResourceMediatorGameObjectVariableInstancer, ResourceMediatorGameObjectEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorGameObjectEventReference : AtomEventReference<
        ResourceMediatorGameObject,
        ResourceMediatorGameObjectVariable,
        ResourceMediatorGameObjectEvent,
        ResourceMediatorGameObjectVariableInstancer,
        ResourceMediatorGameObjectEventInstancer>, IGetEvent 
    { }
}
