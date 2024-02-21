using UnityEngine;
using System;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    public sealed partial class ResourceMediatorGameObjectVariable : AtomVariable<ResourceMediatorGameObject, ResourceMediatorGameObjectPair, ResourceMediatorGameObjectEvent, ResourceMediatorGameObjectPairEvent, ResourceMediatorGameObjectResourceMediatorGameObjectFunction>
    {
        [SerializeField, Tooltip("Whether initialize to clear list of resources on enable")] private bool _clearOnEnable = true;
        
        protected override void OnEnable()
        {
            base.OnEnable();
        
            if (_clearOnEnable)
            {
                Value.Clear();
            }
        }
    }
}