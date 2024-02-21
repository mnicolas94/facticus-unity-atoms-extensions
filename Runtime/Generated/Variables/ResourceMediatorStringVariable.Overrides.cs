using UnityEngine;
using System;
using UnityAtomsExtensions.ResourceMediator;

namespace UnityAtoms.BaseAtoms
{
    [Serializable]
    public sealed partial class ResourceMediatorStringVariable : AtomVariable<ResourceMediatorString, ResourceMediatorStringPair, ResourceMediatorStringEvent, ResourceMediatorStringPairEvent, ResourceMediatorStringResourceMediatorStringFunction>
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
