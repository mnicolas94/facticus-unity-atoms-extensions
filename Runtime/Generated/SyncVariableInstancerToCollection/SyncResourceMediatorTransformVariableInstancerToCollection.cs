using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.PrioritizedValues;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync ResourceMediatorTransform Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncResourceMediatorTransformVariableInstancerToCollection : SyncVariableInstancerToCollection<UnityAtomsExtensions.PrioritizedValues.ResourceMediatorTransform, ResourceMediatorTransformVariable, ResourceMediatorTransformVariableInstancer> { }
}
