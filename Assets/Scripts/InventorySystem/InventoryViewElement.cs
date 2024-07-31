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

    [SerializeField] private Item item;

    public void Show()
    {
        itemName.text = item.itemName;
        image.sprite = item.itemIcon;
    }
}
