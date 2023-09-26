using System.Collections.Generic;
using UnityEngine;

namespace UnityAtomsExtensions.PrioritizedValues
{
    public abstract class PrioritizedValue<T> : ScriptableObject
    {
        [SerializeField] private List<T> _list;
        [SerializeField] private bool _returnOldest;

        public bool HasValue()
        {
            return _list.Count > 0;
        }

        public T GetCurrentValue()
        {
            if (_returnOldest)
            {
                return _list[0];
            }
            else
            {
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
}