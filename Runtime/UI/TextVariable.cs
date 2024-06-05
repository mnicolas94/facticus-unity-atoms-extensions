using System;
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
        [SerializeField] private string _format;

        private void OnEnable()
        {
            UpdateUi();
            _variable.Changed.Register(UpdateUi);
        }

        private void OnDisable()
        {
            _variable.Changed.Unregister(UpdateUi);
        }
        
        [ContextMenu(nameof(UpdateUi))]
        public void UpdateUi()
        {
            var formattedText = GetVariableText();
            SetText(formattedText);
        }

        private string GetVariableText()
        {
            return Format(_variable.Value);
        }

        private void SetText(string variableText)
        {
            _text.SetText(variableText);
        }

        private string Format(TT value)
        {
            string text;
            if (!string.IsNullOrEmpty(_format))
            {
                text = string.Format(_format, value);
            }
            else
            {
                text = value.ToString();
            }
            return $"{_prefix}{text}{_suffix}";
        }

#if UNITY_EDITOR
        private void OnValidate()
        {
            UpdateUi();
        }
#endif
    }
}