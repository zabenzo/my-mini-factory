using UnityEngine;

namespace Game.ProductionObjects
{
    public class BrickBlock : MonoBehaviour, IPickable
    {
        public void PickUp(GameObject arms)
        {
            Debug.Log($"{gameObject.name} picked.");
            gameObject.transform.SetParent(arms.transform);
        }
    }
}