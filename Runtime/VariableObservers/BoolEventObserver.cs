using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtomsExtensions.VariableObservers
{
    public class BoolEventObserver : MonoBehaviour
    {
        [SerializeField] private BoolEvent _boolEvent;
        [SerializeField] private UnityEvent _onTrue;
        [SerializeField] private UnityEvent _onFalse;

        private void OnEnable()
        {
            _boolEvent.Register(OnChanged);
        }

        private void OnDisable()
        {
            _boolEvent.Unregister(OnChanged);
        }

        private void OnChanged(bool value)
        {
            var evt = value ? _onTrue : _onFalse;
            evt.Invoke();
        }
    }
}