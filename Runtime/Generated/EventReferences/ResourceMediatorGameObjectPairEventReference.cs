using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `ResourceMediatorGameObjectPair`. Inherits from `AtomEventReference&lt;ResourceMediatorGameObjectPair, ResourceMediatorGameObjectVariable, ResourceMediatorGameObjectPairEvent, ResourceMediatorGameObjectVariableInstancer, ResourceMediatorGameObjectPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorGameObjectPairEventReference : AtomEventReference<
        ResourceMediatorGameObjectPair,
        ResourceMediatorGameObjectVariable,
        ResourceMediatorGameObjectPairEvent,
        ResourceMediatorGameObjectVariableInstancer,
        ResourceMediatorGameObjectPairEventInstancer>, IGetEvent 
    { }
}
