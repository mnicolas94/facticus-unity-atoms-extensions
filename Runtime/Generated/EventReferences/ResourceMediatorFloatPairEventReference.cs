using System;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `ResourceMediatorFloatPair`. Inherits from `AtomEventReference&lt;ResourceMediatorFloatPair, ResourceMediatorFloatVariable, ResourceMediatorFloatPairEvent, ResourceMediatorFloatVariableInstancer, ResourceMediatorFloatPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorFloatPairEventReference : AtomEventReference<
        ResourceMediatorFloatPair,
        ResourceMediatorFloatVariable,
        ResourceMediatorFloatPairEvent,
        ResourceMediatorFloatVariableInstancer,
        ResourceMediatorFloatPairEventInstancer>, IGetEvent 
    { }
}
