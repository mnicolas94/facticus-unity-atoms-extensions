using UnityEngine;
using System;
using UnityAtomsExtensions.Samples;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `UnityAtomsExtensions.Samples.TestObject`. Inherits from `AtomVariable&lt;UnityAtomsExtensions.Samples.TestObject, TestObjectPair, TestObjectEvent, TestObjectPairEvent, TestObjectTestObjectFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/TestObject", fileName = "TestObjectVariable")]
    public sealed class TestObjectVariable : AtomVariable<UnityAtomsExtensions.Samples.TestObject, TestObjectPair, TestObjectEvent, TestObjectPairEvent, TestObjectTestObjectFunction>
    {
        protected override bool ValueEquals(UnityAtomsExtensions.Samples.TestObject other)
        {
            return _value == other;
        }
    }
}
