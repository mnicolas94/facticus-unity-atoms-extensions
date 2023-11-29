using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync ResourceMediatorInt Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncResourceMediatorIntVariableInstancerToCollection : SyncVariableInstancerToCollection<UnityAtomsExtensions.PrioritizedValues.ResourceMediatorInt, ResourceMediatorIntVariable, ResourceMediatorIntVariableInstancer> { }
}
