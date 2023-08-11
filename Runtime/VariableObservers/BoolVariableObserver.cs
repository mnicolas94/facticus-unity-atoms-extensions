using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtomsExtensions.VariableObservers
{
    public class BoolVariableObserver : MonoBehaviour
    {
        [SerializeField] private BoolVariable _boolVariable;
        [SerializeField] private bool _evaluateOnEnable;
        [SerializeField] private UnityEvent _onTrue;
        [SerializeField] private UnityEvent _onFalse;

        private void OnEnable()
        {
            _boolVariable.Changed.Register(OnChanged);
            if (_evaluateOnEnable)
            {
                OnChanged(_boolVariable.Value);
            }
        }

        private void OnDisable()
        {
            _boolVariable.Changed.Unregister(OnChanged);
        }

        private void OnChanged(bool value)
        {
            var evt = value ? _onTrue : _onFalse;
            evt.Invoke();
        }
    }
}