using System;
using UnityEngine;

namespace UnityAtomsExtensions.ResourceMediator
{
    public class ResourceMediatorScriptableObject<T> : ScriptableObject
    {
        [SerializeField] private bool _clearOnEnable = true;
        [SerializeField] private ResourceMediator<T> _resource = new();

        public ResourceMediator<T> Resource => _resource;

        private void OnEnable()
        {
            if (_clearOnEnable)
            {
                _resource.Clear();
            }
        }
    }
}