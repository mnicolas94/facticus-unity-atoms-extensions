using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace AtomsExtensions
{
    public class FloatStatisticsComponent : MonoBehaviour
    {
        [SerializeField] private FloatReference _statModifier;
        
        public void AddAddBuff(FloatStatistic stats)
        {
            stats.AddAddBuff(_statModifier);
        }

        public void AddScaleBuff(FloatStatistic stats)
        {
            stats.AddScaleBuff(_statModifier);
        }
        
        public void RemoveAddBuff(FloatStatistic stats)
        {
            stats.RemoveAddBuff(_statModifier);
        }
        
        public void RemoveScaleBuff(FloatStatistic stats)
        {
            stats.RemoveScaleBuff(_statModifier);
        }
    }
}