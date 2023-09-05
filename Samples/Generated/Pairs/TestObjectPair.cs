using System;
using UnityEngine;
using UnityAtomsExtensions.Samples;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityAtomsExtensions.Samples.TestObject&gt;`. Inherits from `IPair&lt;UnityAtomsExtensions.Samples.TestObject&gt;`.
    /// </summary>
    [Serializable]
    public struct TestObjectPair : IPair<UnityAtomsExtensions.Samples.TestObject>
    {
        public UnityAtomsExtensions.Samples.TestObject Item1 { get => _item1; set => _item1 = value; }
        public UnityAtomsExtensions.Samples.TestObject Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private UnityAtomsExtensions.Samples.TestObject _item1;
        [SerializeField]
        private UnityAtomsExtensions.Samples.TestObject _item2;

        public void Deconstruct(out UnityAtomsExtensions.Samples.TestObject item1, out UnityAtomsExtensions.Samples.TestObject item2) { item1 = Item1; item2 = Item2; }
    }
}