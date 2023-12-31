using System;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat`. Inherits from `AtomEventReference&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat, ResourceMediatorFloatVariable, ResourceMediatorFloatEvent, ResourceMediatorFloatVariableInstancer, ResourceMediatorFloatEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorFloatEventReference : AtomEventReference<
        ResourceMediatorFloat,
        ResourceMediatorFloatVariable,
        ResourceMediatorFloatEvent,
        ResourceMediatorFloatVariableInstancer,
        ResourceMediatorFloatEventInstancer>, IGetEvent 
    { }
}
