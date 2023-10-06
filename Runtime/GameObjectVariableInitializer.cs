using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtomsExtensions
{
    public class GameObjectVariableInitializer : MonoBehaviour
    {
        [SerializeField] private GameObjectVariable _variable;
        [SerializeField] private bool _setNullOnDisable = true;

        private void OnEnable()
        {
            _variable.Value = gameObject;
        }

        private void OnDisable()
        {
            if (_setNullOnDisable && _variable.Value == gameObject)
            {
                _variable.Value = null;
            }
        }
    }
}