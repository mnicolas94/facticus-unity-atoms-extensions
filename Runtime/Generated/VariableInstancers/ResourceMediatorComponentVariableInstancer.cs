using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent`. Inherits from `AtomVariableInstancer&lt;ResourceMediatorComponentVariable, ResourceMediatorComponentPair, UnityAtomsExtensions.PrioritizedValues.ResourceMediatorComponent, ResourceMediatorComponentEvent, ResourceMediatorComponentPairEvent, ResourceMediatorComponentResourceMediatorComponentFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/ResourceMediatorComponent Variable Instancer")]
    public class ResourceMediatorComponentVariableInstancer : AtomVariableInstancer<
        ResourceMediatorComponentVariable,
        ResourceMediatorComponentPair,
        ResourceMediatorComponent,
        ResourceMediatorComponentEvent,
        ResourceMediatorComponentPairEvent,
        ResourceMediatorComponentResourceMediatorComponentFunction>
    {
        protected override void ImplSpecificSetup()
        {
            base.ImplSpecificSetup();
            _inMemoryCopy.Value ??= new ResourceMediatorComponent();
        }
    }
}
