using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString`. Inherits from `AtomVariableInstancer&lt;ResourceMediatorStringVariable, ResourceMediatorStringPair, UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString, ResourceMediatorStringEvent, ResourceMediatorStringPairEvent, ResourceMediatorStringResourceMediatorStringFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/ResourceMediatorString Variable Instancer")]
    public class ResourceMediatorStringVariableInstancer : AtomVariableInstancer<
        ResourceMediatorStringVariable,
        ResourceMediatorStringPair,
        ResourceMediatorString,
        ResourceMediatorStringEvent,
        ResourceMediatorStringPairEvent,
        ResourceMediatorStringResourceMediatorStringFunction>
    {
        protected override void ImplSpecificSetup()
        {
            base.ImplSpecificSetup();
            _inMemoryCopy.Value ??= new ResourceMediatorString();
        }
    }
}
