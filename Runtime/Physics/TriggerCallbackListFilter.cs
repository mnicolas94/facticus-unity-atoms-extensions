using UnityAtoms.BaseAtoms;
using UnityAtomsExtensions.Utils;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtomsExtensions.Physics
{
    public class TriggerCallbackListFilter : MonoBehaviour
    {
        [SerializeField] private LayerMask _mask;
        [SerializeField] private GameObjectValueList _list;

        [SerializeField] private UnityEvent<Collider> _onTriggerEnter;
        [SerializeField] private UnityEvent<Collider> _onTriggerExit;

        private bool CanTriggerWithObject(GameObject go)
        {
            return _list.Contains(go) && _mask.IsLayerInMask(go.layer);
        }
        
        private void OnTriggerEnter(Collider other)
        {
            var go = other.gameObject;
            if (CanTriggerWithObject(go))
            {
                _onTriggerEnter.Invoke(other);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            var go = other.gameObject;
            if (CanTriggerWithObject(go))
            {
                _onTriggerExit.Invoke(other);
            }
        }
    }
}