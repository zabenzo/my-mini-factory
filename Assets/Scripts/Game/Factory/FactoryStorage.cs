using System.Collections.Generic;
using System.Linq;
using Game.ProductionObjects;
using UnityEngine;

namespace Game.Factory
{
    public class FactoryStorage : MonoBehaviour
    {
        public List<IPickable> PickableObjects { get; private set; }

        private void Awake()
        {
            PickableObjects = new List<IPickable>();

            PickableObjects = GetComponentsInChildren<IPickable>().ToList();
        }
    }
}