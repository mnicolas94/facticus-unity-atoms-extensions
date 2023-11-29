using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `ResourceMediatorBoolPair`. Inherits from `AtomEventReference&lt;ResourceMediatorBoolPair, ResourceMediatorBoolVariable, ResourceMediatorBoolPairEvent, ResourceMediatorBoolVariableInstancer, ResourceMediatorBoolPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorBoolPairEventReference : AtomEventReference<
        ResourceMediatorBoolPair,
        ResourceMediatorBoolVariable,
        ResourceMediatorBoolPairEvent,
        ResourceMediatorBoolVariableInstancer,
        ResourceMediatorBoolPairEventInstancer>, IGetEvent 
    { }
}
