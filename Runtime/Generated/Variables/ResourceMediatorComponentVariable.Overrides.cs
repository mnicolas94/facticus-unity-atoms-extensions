using UnityEngine;
using System;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    public sealed partial class ResourceMediatorComponentVariable : AtomVariable<ResourceMediatorComponent, ResourceMediatorComponentPair, ResourceMediatorComponentEvent, ResourceMediatorComponentPairEvent, ResourceMediatorComponentResourceMediatorComponentFunction>
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
