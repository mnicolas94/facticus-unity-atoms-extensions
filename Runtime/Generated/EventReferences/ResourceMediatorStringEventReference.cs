using System;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString`. Inherits from `AtomEventReference&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString, ResourceMediatorStringVariable, ResourceMediatorStringEvent, ResourceMediatorStringVariableInstancer, ResourceMediatorStringEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorStringEventReference : AtomEventReference<
        ResourceMediatorString,
        ResourceMediatorStringVariable,
        ResourceMediatorStringEvent,
        ResourceMediatorStringVariableInstancer,
        ResourceMediatorStringEventInstancer>, IGetEvent 
    { }
}
