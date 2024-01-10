using System.Collections.Generic;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtomsExtensions.StatisticsVariables
{
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/FloatStatistic", fileName = "FloatStatistic")]
    public class FloatStatistic : EquatableAtomVariable<float, FloatPair, FloatEvent, FloatPairEvent, FloatFloatFunction>
    {
        [SerializeField] private List<FloatReference> _addBuffs = new List<FloatReference>();
        [SerializeField] private List<FloatReference> _scaleBuffs = new List<FloatReference>();

        public bool HasAddBuff(FloatReference buff)
        {
            return _addBuffs.Contains(buff);
        }
        
        public bool HasScaleBuff(FloatReference buff)
        {
            return _scaleBuffs.Contains(buff);
        }
        
        public void AddAddBuff(FloatReference buff)
        {
            _addBuffs.Add(buff);
            if (buff.Value != 0)
            {
                Changed.Raise();
            }
        }

        public void AddScaleBuff(FloatReference buff)
        {
            _scaleBuffs.Add(buff);
            if (buff.Value != 0)
            {
                Changed.Raise();
            }
        }
        
        public void RemoveAddBuff(FloatReference buff)
        {
            var removed = _addBuffs.Remove(buff);
            if (buff.Value != 0 && removed)
            {
                Changed.Raise();
            }
        }
        
        public void RemoveScaleBuff(FloatReference buff)
        {
            var removed = _scaleBuffs.Remove(buff);
            if (buff.Value != 0 && removed)
            {
                Changed.Raise();
            }
        }

        public void ClearModifiers()
        {
            _addBuffs.Clear();
            _scaleBuffs.Clear();
            Changed.Raise();
        }
        
        public float ModifiedValue()
        {
            var value = BaseStatValue;
            foreach (var addBuff in _addBuffs)
            {
                value += addBuff.Value;
            }

            var scale = 1f;
            foreach (var scaleBuff in _scaleBuffs)
            {
                scale += scaleBuff.Value;
            }

            scale = Mathf.Max(0.01f, scale);
            
            value *= scale;

            return value;
        }
        
        public float BaseStatValue { get => _value; set => SetValue(value); }
        
        public override float Value { get => ModifiedValue(); }

        /// <summary>
        /// Add value to Variable.
        /// </summary>
        /// <param name="value">Value to add.</param>
        public void Add(float value) => BaseStatValue += value;

        /// <summary>
        /// Add variable value to Variable.
        /// </summary>
        /// <param name="variable">Variable with value to add.</param>
        public void Add(AtomBaseVariable<float> variable) => Add(variable.Value);

        /// <summary>
        /// Subtract value from Variable.
        /// </summary>
        /// <param name="value">Value to subtract.</param>
        public void Subtract(float value) => BaseStatValue -= value;

        /// <summary>
        /// Subtract variable value from Variable.
        /// </summary>
        /// <param name="variable">Variable with value to subtract.</param>
        public void Subtract(AtomBaseVariable<float> variable) => Subtract(variable.Value);

        /// <summary>
        /// Multiply variable by value.
        /// </summary>
        /// <param name="value">Value to multiple by.</param>
        public void MultiplyBy(float value) => BaseStatValue *= value;

        /// <summary>
        /// Multiply variable by Variable value.
        /// </summary>
        /// <param name="variable">Variable with value to multiple by.</param>
        public void MultiplyBy(AtomBaseVariable<float> variable) => MultiplyBy(variable.Value);

        /// <summary>
        /// Divide Variable by value.
        /// </summary>
        /// <param name="value">Value to divide by.</param>
        public void DivideBy(float value) => BaseStatValue /= value;

        /// <summary>
        /// Divide Variable by Variable value.
        /// </summary>
        /// <param name="variable">Variable value to divide by.</param>
        public void DivideBy(AtomBaseVariable<float> variable) => DivideBy(variable.Value);
    }
}