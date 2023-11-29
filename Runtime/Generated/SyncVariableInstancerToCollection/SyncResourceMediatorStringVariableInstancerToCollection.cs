using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync ResourceMediatorString Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncResourceMediatorStringVariableInstancerToCollection : SyncVariableInstancerToCollection<UnityAtomsExtensions.PrioritizedValues.ResourceMediatorString, ResourceMediatorStringVariable, ResourceMediatorStringVariableInstancer> { }
}
