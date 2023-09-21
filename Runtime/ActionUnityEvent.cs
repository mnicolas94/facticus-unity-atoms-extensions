using UnityAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtomsExtensions
{
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Unity event", fileName = "Action")]
    public class ActionUnityEvent : AtomAction
    {
        [SerializeField] private UnityEvent _actions;

        public override void Do()
        {
            _actions.Invoke();
        }
    }
}