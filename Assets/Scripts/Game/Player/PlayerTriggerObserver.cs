using System;
using UnityEngine;

namespace Game.Player
{
    public class PlayerTriggerObserver : MonoBehaviour
    {
        public event Action<Collider> OnZoneEnter;

        private void OnTriggerEnter(Collider other)
        {
            OnZoneEnter?.Invoke(other);
        }
    }
}