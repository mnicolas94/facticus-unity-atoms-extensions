using System;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtomsExtensions
{
    public enum RemoveMode{
        OnDisable,
        OnDestroy
    }
    public class GameObjectListAppender : MonoBehaviour
    {
        [SerializeField] private RemoveMode _removeOn;
        [SerializeField] private List<GameObjectValueList> _listsToAppend;

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
                list.Add(gameObject);
            }
        }
        
        private void RemoveFromLists()
        {
            foreach (var list in _listsToAppend)
            {
                list.Remove(gameObject);
            }
        }
    }
}