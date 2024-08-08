using System.Collections;
using System.Collections.Generic;
using InventorySystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryViewElement : MonoBehaviour
{
    // menapilkan icon, nama dan jumlah item
    
    [SerializeField] private TextMeshProUGUI itemName;
    [SerializeField] private TextMeshProUGUI itemQuantity;
    [SerializeField] private Image image;

    private Item currentItem;

    public void Show(Item item)
    {
        currentItem = item;
        itemName.text = item.itemName;
        image.sprite = item.itemIcon;
    }
}
