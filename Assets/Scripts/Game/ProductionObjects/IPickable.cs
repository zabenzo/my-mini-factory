using UnityEngine;

namespace Game.ProductionObjects
{
    public interface IPickable
    {
        void PickUp(GameObject playerArms);
    }
}