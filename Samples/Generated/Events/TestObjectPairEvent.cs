using UnityEngine;
using UnityAtomsExtensions.Samples;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `TestObjectPair`. Inherits from `AtomEvent&lt;TestObjectPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/TestObjectPair", fileName = "TestObjectPairEvent")]
    public sealed class TestObjectPairEvent : AtomEvent<TestObjectPair>
    {
    }
}
