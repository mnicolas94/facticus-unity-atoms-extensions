using UnityAtoms.BaseAtoms;
using UnityAtoms.Editor;
using UnityAtomsExtensions.StatisticsVariables;
using UnityEditor;

namespace UnityAtomsExtensions.Editor.CustomEditors
{
    /// <summary>
    /// Variable Inspector of type `float`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(FloatStatistic))]
    public sealed class FloatStatisticEditor : AtomVariableEditorExtended<float, FloatPair> { }
}