using UnityEngine;

namespace DefaultNamespace
{
    public class PlayerInventory : MonoBehaviour
    {
        [SerializeField] private PlayerInventoryUI ui;
        
        private int coin = 0;

        public void Add(string item)
        {
            if (item == "coin") coin++;

            ui.UpdateItems(coin);
        }
    }
}