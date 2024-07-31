using UnityEngine;

namespace InventorySystem
{
    [CreateAssetMenu(fileName = "item", menuName = "ItemType")]
    public class Item : ScriptableObject
    {
        public string itemName;
        public int itemId;
        public Sprite itemIcon;
        public ItemType itemType;
        
        
        public enum ItemType
        {
            Potion,
            Coin,
        }
    }
}