using System.Collections.Generic;
using Game.Player;
using Game.ProductionObjects;
using UnityEngine;

namespace Game.Factory
{
    public class FactoryLogic : MonoBehaviour
    {
        private FactoryTriggerObserver _factoryTriggerObserver;
        private List<IPickable> _factoryStorage;

        private void Awake()
        {
            _factoryTriggerObserver = GetComponent<FactoryTriggerObserver>();
            _factoryStorage = GetComponent<FactoryStorage>().PickableObjects;
            
            _factoryTriggerObserver.OnFactoryPickZoneEnter += GivePlayerPickableObjects;
        }

        private void GivePlayerPickableObjects(Collider obj)
        {
            if (obj.TryGetComponent(out PlayerPickLogic playerPickLogic))
            {
                playerPickLogic.TakePickableObjects(_factoryStorage);
            }
        }
    }
}