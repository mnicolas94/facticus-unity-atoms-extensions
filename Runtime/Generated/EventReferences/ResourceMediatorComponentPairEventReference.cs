using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `ResourceMediatorComponentPair`. Inherits from `AtomEventReference&lt;ResourceMediatorComponentPair, ResourceMediatorComponentVariable, ResourceMediatorComponentPairEvent, ResourceMediatorComponentVariableInstancer, ResourceMediatorComponentPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorComponentPairEventReference : AtomEventReference<
        ResourceMediatorComponentPair,
        ResourceMediatorComponentVariable,
        ResourceMediatorComponentPairEvent,
        ResourceMediatorComponentVariableInstancer,
        ResourceMediatorComponentPairEventInstancer>, IGetEvent 
    { }
}
