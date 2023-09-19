using UnityAtoms;
using UnityEngine;

namespace UnityAtomsExtensions
{
    public class ObjectReferenceInitializer<T, TV, P, C, V, E1, E2, F, VI> : MonoBehaviour
        where T : Object
        where TV : AtomReference<T, P, C, V, E1, E2, F, VI>
        where P : struct, IPair<T>
        where C : AtomBaseVariable<T>
        where V : AtomVariable<T, P, E1, E2, F>
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<P>
        where F : AtomFunction<T, T>
        where VI : AtomVariableInstancer<V, P, T, E1, E2, F>
    {
        [SerializeField] private T _value;
        [SerializeField] private TV _variable;

        private void OnEnable()
        {
            _variable.Value = _value;
        }

        private void OnDisable()
        {
            if (_variable.Value == _value)
            {
                _variable.Value = null;
            }
        }
    }
}