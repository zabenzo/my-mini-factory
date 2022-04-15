using System;
using UnityEngine;

namespace Game.Factory
{
    public class FactoryTriggerObserver : MonoBehaviour
    {
        public event Action<Collider> OnFactoryPickZoneEnter;

        private void OnTriggerEnter(Collider other)
        {
            OnFactoryPickZoneEnter?.Invoke(other);
        }
    }
}