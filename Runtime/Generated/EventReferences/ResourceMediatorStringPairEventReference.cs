using System;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `ResourceMediatorStringPair`. Inherits from `AtomEventReference&lt;ResourceMediatorStringPair, ResourceMediatorStringVariable, ResourceMediatorStringPairEvent, ResourceMediatorStringVariableInstancer, ResourceMediatorStringPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorStringPairEventReference : AtomEventReference<
        ResourceMediatorStringPair,
        ResourceMediatorStringVariable,
        ResourceMediatorStringPairEvent,
        ResourceMediatorStringVariableInstancer,
        ResourceMediatorStringPairEventInstancer>, IGetEvent 
    { }
}
