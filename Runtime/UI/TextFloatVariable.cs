using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtomsExtensions.UI
{
    public class TextFloatVariable : TextVariable<FloatVariable, float, FloatPair, FloatEvent, FloatPairEvent, FloatFloatFunction>
    {
        [SerializeField] private int _decimalPlaces;

        protected override string GetVariableText()
        {
            return _variable.Value.ToString($"F{_decimalPlaces}");
        }
    }
}