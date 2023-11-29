using System;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `ResourceMediatorIntPair`. Inherits from `AtomEventReference&lt;ResourceMediatorIntPair, ResourceMediatorIntVariable, ResourceMediatorIntPairEvent, ResourceMediatorIntVariableInstancer, ResourceMediatorIntPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorIntPairEventReference : AtomEventReference<
        ResourceMediatorIntPair,
        ResourceMediatorIntVariable,
        ResourceMediatorIntPairEvent,
        ResourceMediatorIntVariableInstancer,
        ResourceMediatorIntPairEventInstancer>, IGetEvent 
    { }
}
