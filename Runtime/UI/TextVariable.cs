using TMPro;
using UnityAtoms;
using UnityEngine;

namespace UnityAtomsExtensions.UI
{
    public abstract class TextVariable<T, TT, P, E1, E2, F> : MonoBehaviour
        where T : AtomVariable<TT, P, E1, E2, F>
        where P : struct, IPair<TT>
        where E1 : AtomEvent<TT>
        where E2 : AtomEvent<P>
        where F : AtomFunction<TT, TT>
    {
        [SerializeField] protected T _variable;
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private string _prefix;
        [SerializeField] private string _suffix;

        private void OnEnable()
        {
            UpdateUi();
            _variable.Changed.Register(UpdateUi);
        }

        private void OnDisable()
        {
            _variable.Changed.Unregister(UpdateUi);
        }

        public void UpdateUi()
        {
            SetText(GetVariableText());
        }

        protected virtual string GetVariableText()
        {
            return _variable.Value.ToString();
        }

        protected void SetText(string variableText)
        {
            _text.SetText($"{_prefix}{variableText}{_suffix}");
        }

    }
}