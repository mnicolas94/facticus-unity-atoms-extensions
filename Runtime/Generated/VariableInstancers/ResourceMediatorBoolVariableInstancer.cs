using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool`. Inherits from `AtomVariableInstancer&lt;ResourceMediatorBoolVariable, ResourceMediatorBoolPair, UnityAtomsExtensions.PrioritizedValues.ResourceMediatorBool, ResourceMediatorBoolEvent, ResourceMediatorBoolPairEvent, ResourceMediatorBoolResourceMediatorBoolFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/ResourceMediatorBool Variable Instancer")]
    public class ResourceMediatorBoolVariableInstancer : AtomVariableInstancer<
        ResourceMediatorBoolVariable,
        ResourceMediatorBoolPair,
        ResourceMediatorBool,
        ResourceMediatorBoolEvent,
        ResourceMediatorBoolPairEvent,
        ResourceMediatorBoolResourceMediatorBoolFunction>
    {
        protected override void ImplSpecificSetup()
        {
            base.ImplSpecificSetup();
            _inMemoryCopy.Value ??= new ResourceMediatorBool();
        }
    }
}
