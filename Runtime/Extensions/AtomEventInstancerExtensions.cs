using System.Threading;
using System.Threading.Tasks;
using UnityAtoms;

namespace UnityAtomsExtensions.Extensions
{
    public static class AtomEventInstancerExtensions
    {
        /// <summary>
        /// Asynchronous method to wait for an Event instancer to instantiate the event. Useful if you need to
        /// access the event inside an Awake or OnEnable method where the instancer's event may not be instantiated yet.
        /// </summary>
        /// <param name="instancer"></param>
        /// <param name="ct"></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="E"></typeparam>
        public static async Task WaitInstantiation<T, E>(this AtomEventInstancer<T, E> instancer, CancellationToken ct)
            where E : AtomEvent<T>
        {
            while (instancer.Event == null && !ct.IsCancellationRequested)
            {
                await Task.Yield();
            }
        }
    }
}