using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `ResourceMediatorTransformPair`. Inherits from `AtomEventReference&lt;ResourceMediatorTransformPair, ResourceMediatorTransformVariable, ResourceMediatorTransformPairEvent, ResourceMediatorTransformVariableInstancer, ResourceMediatorTransformPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ResourceMediatorTransformPairEventReference : AtomEventReference<
        ResourceMediatorTransformPair,
        ResourceMediatorTransformVariable,
        ResourceMediatorTransformPairEvent,
        ResourceMediatorTransformVariableInstancer,
        ResourceMediatorTransformPairEventInstancer>, IGetEvent 
    { }
}
