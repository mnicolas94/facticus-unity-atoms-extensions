using UnityAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtomsExtensions.VariableObservers
{
    public abstract class VariableObserver<T, TT, P, E1, E2, F> : MonoBehaviour
        where T : AtomVariable<TT, P, E1, E2, F>
        where P : struct, IPair<TT>
        where E1 : AtomEvent<TT>
        where E2 : AtomEvent<P>
        where F : AtomFunction<TT, TT>
    {
        [SerializeField] private T _variable;

        [SerializeField] private UnityEvent<TT> _onColorChanged;

        private void OnEnable()
        {
            _variable.Changed.Register(OnValueChanged);
            OnValueChanged(_variable.Value);
        }

        private void OnDisable()
        {
            _variable.Changed.Unregister(OnValueChanged);
        }

        private void OnValueChanged(TT value)
        {
            _onColorChanged.Invoke(value);
        }
    }
}