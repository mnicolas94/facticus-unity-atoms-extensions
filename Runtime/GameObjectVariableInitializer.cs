using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtomsExtensions
{
    public class GameObjectVariableInitializer : MonoBehaviour
    {
        [SerializeField] private GameObjectVariable _variable;

        private void OnEnable()
        {
            _variable.Value = gameObject;
        }

        private void OnDisable()
        {
            if (_variable.Value == gameObject)
            {
                _variable.Value = null;
            }
        }
    }
}