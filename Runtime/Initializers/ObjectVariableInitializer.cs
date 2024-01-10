using UnityAtoms;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using Object = UnityEngine.Object;

namespace UnityAtomsExtensions.Initializers
{
    [MovedFrom(true, "UnityAtomsExtensions")]
    public abstract class ObjectVariableInitializer<T, TV> : MonoBehaviour
        where T : Object
        where TV : AtomBaseVariable<T>
    {
        [SerializeField] private T _value;
        [SerializeField] private TV _variable;
        [SerializeField] private bool _setNullOnDisable = true;

        private void OnEnable()
        {
            _variable.Value = _value;
        }

        private void OnDisable()
        {
            if (_setNullOnDisable && _variable.Value == _value)
            {
                _variable.Value = null;
            }
        }
    }
}