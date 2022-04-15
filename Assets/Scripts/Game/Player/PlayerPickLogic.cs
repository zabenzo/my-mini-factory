using System.Collections.Generic;
using Game.ProductionObjects;
using UnityEngine;

namespace Game.Player
{
    public class PlayerPickLogic : MonoBehaviour
    {
        private PlayerTriggerObserver _playerTriggerObserver;
        private List<IPickable> _pickableObjectsInArms;

        private void Awake()
        {
            _playerTriggerObserver = GetComponent<PlayerTriggerObserver>();
        }

        public void TakePickableObjects(List<IPickable> factoryStorage)
        {
            foreach (var pickableObject in factoryStorage)
            {
                pickableObject.PickUp(gameObject);
            }
        }
    }
}