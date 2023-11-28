using System.Threading;
using System.Threading.Tasks;
using UnityAtoms;

namespace UnityAtomsExtensions.Extensions
{
    public static class AtomBaseEventReferenceExtensions
    {
        /// <summary>
        /// Asynchronous method to wait for an Event reference to have its internal value instantiated in case
        /// its usage is of instancer type. Useful if you need to access the event inside an Awake or OnEnable method
        /// where the instancer's event may not be instantiated yet.
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="ct"></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="E"></typeparam>
        /// <typeparam name="EI"></typeparam>
        public static async Task WaitInstantiation<T, E, EI>(this AtomBaseEventReference<T, E, EI> reference,
            CancellationToken ct)
            where E : AtomEvent<T>
            where EI : AtomEventInstancer<T, E>
        {
            while (reference.Event == null && !ct.IsCancellationRequested)
            {
                await Task.Yield();
            }
        }
    }
}