using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtomsExtensions.PrioritizedValues
{
    public enum MediationOrder
    {
        FIFO,  // first in first out
        LIFO  // last in first out
    }
    
    [Serializable]
    public class ResourceMediator<T>
    {
        [SerializeField] private List<T> _list = new ();
        [SerializeField] private MediationOrder _order;

        public bool HasValue()
        {
            return _list.Count > 0;
        }

        public T GetCurrentValue()
        {
            switch (_order)
            {
                case MediationOrder.FIFO:
                    return _list[0];
                case MediationOrder.LIFO:
                default:
                    return _list[_list.Count - 1];
            }
        }

        public void SetValue(T value)
        {
            _list.Add(value);
        }
        
        public void RemoveValue(T value)
        {
            _list.Remove(value);
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
    
    // Common types
    
    [Serializable]
    public class ResourceMediatorBool : ResourceMediator<bool> {}
        
    [Serializable]
    public class ResourceMediatorInt : ResourceMediator<int> {}

    [Serializable]
    public class ResourceMediatorFloat : ResourceMediator<float> {}

    [Serializable]
    public class ResourceMediatorString : ResourceMediator<string> {}

    [Serializable]
    public class ResourceMediatorGameObject : ResourceMediator<GameObject> {}

    [Serializable]
    public class ResourceMediatorTransform : ResourceMediator<Transform> {}
}