using System;
using UnityEngine;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    public sealed partial class ResourceMediatorBoolVariable : AtomVariable<ResourceMediatorBool, ResourceMediatorBoolPair, ResourceMediatorBoolEvent, ResourceMediatorBoolPairEvent, ResourceMediatorBoolResourceMediatorBoolFunction>
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
