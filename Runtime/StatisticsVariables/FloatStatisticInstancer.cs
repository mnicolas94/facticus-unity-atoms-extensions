using UnityAtoms;
using UnityAtoms.BaseAtoms;

namespace UnityAtomsExtensions.StatisticsVariables
{
    public class FloatStatisticInstancer : AtomVariableInstancer<
        FloatStatistic,
        FloatPair,
        float,
        FloatEvent,
        FloatPairEvent,
        FloatFloatFunction>
    { }
}