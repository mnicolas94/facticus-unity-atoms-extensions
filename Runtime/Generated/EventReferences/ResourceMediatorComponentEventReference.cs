using System;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent`. Inherits from `AtomEventReference&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent, ResourceMediatorComponentVariable, ResourceMediatorComponentEvent, ResourceMediatorComponentVariableInstancer, ResourceMediatorComponentEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorComponentEventReference : AtomEventReference<
        ResourceMediatorComponent,
        ResourceMediatorComponentVariable,
        ResourceMediatorComponentEvent,
        ResourceMediatorComponentVariableInstancer,
        ResourceMediatorComponentEventInstancer>, IGetEvent 
    { }
}
