using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;

namespace UnityAtomsExtensions
{
    public class ObjectListAppender<T, TL, TE> : MonoBehaviour
        where T : Object
        where TL : AtomValueList<T, TE>
        where TE : AtomEvent<T>
    {
        [SerializeField] private T _element;
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
            foreach (var list in _listsToAppend)
            {
                list.Add(_element);
            }
        }
        
        private void RemoveFromLists()
        {
            foreach (var list in _listsToAppend)
            {
                list.Remove(_element);
            }
        }
    }
}