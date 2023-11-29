using System.Collections.Generic;
using UnityEngine;

namespace UnityAtomsExtensions.PrioritizedValues
{
    public abstract class PrioritizedValue<T> : ScriptableObject
    {
        [SerializeField] private ResourceMediator<T> _mediator;

        public bool HasValue()
        {
            return _mediator.HasValue();
        }

        public T GetCurrentValue()
        {
            return _mediator.GetCurrentValue();
        }

        public void SetValue(T value)
        {
            _mediator.SetValue(value);
        }
        
        public void RemoveValue(T value)
        {
            _mediator.RemoveValue(value);
        }

        public void Clear()
        {
            _mediator.Clear();
        }
    }
}