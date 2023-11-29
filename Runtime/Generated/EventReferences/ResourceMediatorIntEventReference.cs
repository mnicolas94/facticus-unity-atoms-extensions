using System;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt`. Inherits from `AtomEventReference&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt, ResourceMediatorIntVariable, ResourceMediatorIntEvent, ResourceMediatorIntVariableInstancer, ResourceMediatorIntEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorIntEventReference : AtomEventReference<
        ResourceMediatorInt,
        ResourceMediatorIntVariable,
        ResourceMediatorIntEvent,
        ResourceMediatorIntVariableInstancer,
        ResourceMediatorIntEventInstancer>, IGetEvent 
    { }
}
