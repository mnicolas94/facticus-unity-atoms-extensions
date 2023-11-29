using System;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent`. Inherits from `AtomEventReference&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent, ResourceMediatorComponentVariable, ResourceMediatorComponentEvent, ResourceMediatorComponentVariableInstancer, ResourceMediatorComponentEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorComponentEventReference : AtomEventReference<
        UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent,
        ResourceMediatorComponentVariable,
        ResourceMediatorComponentEvent,
        ResourceMediatorComponentVariableInstancer,
        ResourceMediatorComponentEventInstancer>, IGetEvent 
    { }
}
