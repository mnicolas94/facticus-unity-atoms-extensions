using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtomsExtensions.Samples
{
    public class ResourceMediatorTests : MonoBehaviour
    {
        [SerializeField] private ResourceMediatorBoolVariable _boolVariable;
        [SerializeField] private ResourceMediatorBoolReference _boolReference;
        
        [SerializeField] private ResourceMediatorIntVariable _intVariable;
        [SerializeField] private ResourceMediatorIntReference _intReference;
        
        [SerializeField] private ResourceMediatorFloatVariable _floatVariable;
        [SerializeField] private ResourceMediatorFloatReference _floatReference;
        
        [SerializeField] private ResourceMediatorStringVariable _stringVariable;
        [SerializeField] private ResourceMediatorStringReference _stringReference;
        
        [SerializeField] private ResourceMediatorGameObjectVariable _goVariable;
        [SerializeField] private ResourceMediatorGameObjectReference _goReference;
        
        [SerializeField] private ResourceMediatorTransformVariable _transformVariable;
        [SerializeField] private ResourceMediatorTransformReference _transformReference;
    }
}