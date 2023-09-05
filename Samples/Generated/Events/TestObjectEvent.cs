using UnityEngine;
using UnityAtomsExtensions.Samples;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `UnityAtomsExtensions.Samples.TestObject`. Inherits from `AtomEvent&lt;UnityAtomsExtensions.Samples.TestObject&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/TestObject", fileName = "TestObjectEvent")]
    public sealed class TestObjectEvent : AtomEvent<UnityAtomsExtensions.Samples.TestObject>
    {
    }
}
