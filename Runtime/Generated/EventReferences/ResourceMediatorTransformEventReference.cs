using System;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform`. Inherits from `AtomEventReference&lt;UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform, ResourceMediatorTransformVariable, ResourceMediatorTransformEvent, ResourceMediatorTransformVariableInstancer, ResourceMediatorTransformEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorTransformEventReference : AtomEventReference<
        ResourceMediatorTransform,
        ResourceMediatorTransformVariable,
        ResourceMediatorTransformEvent,
        ResourceMediatorTransformVariableInstancer,
        ResourceMediatorTransformEventInstancer>, IGetEvent 
    { }
}
