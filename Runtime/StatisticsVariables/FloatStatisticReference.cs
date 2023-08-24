using System;
using UnityAtoms;
using UnityAtoms.BaseAtoms;

namespace UnityAtomsExtensions.StatisticsVariables
{
    [Serializable]
    public class FloatStatisticReference : EquatableAtomReference<
        float,
        FloatPair,
        FloatConstant,
        FloatStatistic,
        FloatEvent,
        FloatPairEvent,
        FloatFloatFunction,
        FloatStatisticInstancer>, IEquatable<FloatReference>
    {
        public FloatStatisticReference() : base() { }
        public FloatStatisticReference(float value) : base(value) { }
        public bool Equals(FloatReference other) { return base.Equals(other); }
    }
}