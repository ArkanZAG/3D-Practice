using System.Collections.Generic;
using UnityEngine;

namespace InventorySystem
{
    public class Inventory : MonoBehaviour
    {
        [SerializeField] private List<Item> items;

        public List<Item> Items => items;

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void RemoveItem(int index)
        {
            items.RemoveAt(index);
        }
    }
}
