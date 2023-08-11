using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtomsExtensions
{
    public class GameObjectVariableInitializer : MonoBehaviour
    {
        [SerializeField] private GameObjectVariable _variable;

        private void Awake()
        {
            _variable.Value = gameObject;
        }
    }
}