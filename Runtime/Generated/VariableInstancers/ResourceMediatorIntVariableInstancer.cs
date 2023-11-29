using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt`. Inherits from `AtomVariableInstancer&lt;ResourceMediatorIntVariable, ResourceMediatorIntPair, UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt, ResourceMediatorIntEvent, ResourceMediatorIntPairEvent, ResourceMediatorIntResourceMediatorIntFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/ResourceMediatorInt Variable Instancer")]
    public class ResourceMediatorIntVariableInstancer : AtomVariableInstancer<
        ResourceMediatorIntVariable,
        ResourceMediatorIntPair,
        ResourceMediatorInt,
        ResourceMediatorIntEvent,
        ResourceMediatorIntPairEvent,
        ResourceMediatorIntResourceMediatorIntFunction>
    {
        protected override void ImplSpecificSetup()
        {
            base.ImplSpecificSetup();
            _inMemoryCopy.Value ??= new ResourceMediatorInt();
        }
    }
}
