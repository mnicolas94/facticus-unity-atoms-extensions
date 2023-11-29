using System;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool`. Inherits from `AtomEventReference&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool, ResourceMediatorBoolVariable, ResourceMediatorBoolEvent, ResourceMediatorBoolVariableInstancer, ResourceMediatorBoolEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorBoolEventReference : AtomEventReference<
        ResourceMediatorBool,
        ResourceMediatorBoolVariable,
        ResourceMediatorBoolEvent,
        ResourceMediatorBoolVariableInstancer,
        ResourceMediatorBoolEventInstancer>, IGetEvent 
    { }
}
