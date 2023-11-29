using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat`. Inherits from `AtomVariableInstancer&lt;ResourceMediatorFloatVariable, ResourceMediatorFloatPair, UnityAtomsExtensions.PrioritizedValues.ResourceMediatorFloat, ResourceMediatorFloatEvent, ResourceMediatorFloatPairEvent, ResourceMediatorFloatResourceMediatorFloatFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/ResourceMediatorFloat Variable Instancer")]
    public class ResourceMediatorFloatVariableInstancer : AtomVariableInstancer<
        ResourceMediatorFloatVariable,
        ResourceMediatorFloatPair,
        ResourceMediatorFloat,
        ResourceMediatorFloatEvent,
        ResourceMediatorFloatPairEvent,
        ResourceMediatorFloatResourceMediatorFloatFunction>
    {
        protected override void ImplSpecificSetup()
        {
            base.ImplSpecificSetup();
            _inMemoryCopy.Value ??= new ResourceMediatorFloat();
        }
    }
}
