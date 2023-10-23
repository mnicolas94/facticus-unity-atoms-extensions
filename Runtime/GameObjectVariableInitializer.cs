using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtomsExtensions
{
    public class GameObjectVariableInitializer : MonoBehaviour
    {
        [SerializeField] private GameObject _target;
        [SerializeField] private GameObjectVariable _variable;
        [SerializeField] private bool _setNullOnDisable = true;

        private void OnEnable()
        {
            _variable.Value = _target;
        }

        private void OnDisable()
        {
            if (_setNullOnDisable && _variable.Value == _target)
            {
                _variable.Value = null;
            }
        }

#if UNITY_EDITOR
        private void OnValidate()
        {
            if (_target == null)
            {
                _target = gameObject;
            }
        }
#endif
    }
}