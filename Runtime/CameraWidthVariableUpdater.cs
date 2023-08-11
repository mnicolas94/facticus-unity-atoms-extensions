using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtomsExtensions
{
    public class CameraWidthVariableUpdater : MonoBehaviour
    {
        [SerializeField] private Camera _camera;
        [SerializeField] private FloatVariable _widthVariable;

        private void Awake()
        {
            var halfHeight = _camera.orthographicSize;
            _widthVariable.Value = halfHeight * _camera.aspect * 2;
        }
    }
}