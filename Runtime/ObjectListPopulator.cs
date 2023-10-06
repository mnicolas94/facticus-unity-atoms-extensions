using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;

namespace UnityAtomsExtensions
{
    public class ObjectListPopulator<T, TL, TE> : MonoBehaviour
        where TL : AtomValueList<T, TE>
        where TE : AtomEvent<T>
    {
        [SerializeField] private List<T> _elements;
        [SerializeField] private RemoveMode _removeOn;
        [SerializeField] private List<TL> _listsToAppend;

        private void OnEnable()
        {
            AddToLists();
        }

        private void OnDisable()
        {
            if (_removeOn == RemoveMode.OnDisable)
            {
                RemoveFromLists();
            }
        }

        private void OnDestroy()
        {
            if (_removeOn == RemoveMode.OnDestroy)
            {
                RemoveFromLists();
            }
        }

        private void AddToLists()
        {
            foreach (var element in _elements)
            {
                foreach (var list in _listsToAppend)
                {
                    list.Add(element);
                }
            }
        }
        
        private void RemoveFromLists()
        {
            foreach (var element in _elements)
            {
                foreach (var list in _listsToAppend)
                {
                    list.Remove(element);
                }
            }
        }
    }
}