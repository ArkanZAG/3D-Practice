using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace InventorySystem
{
    public class InventoryView : MonoBehaviour
    {
        [SerializeField] private Button openInventoryButton;
        [SerializeField] private Button closeInventoryButton;
        [SerializeField] private GameObject inventoryPanel;
        

        [SerializeField] private Inventory inventory;

        private void Start()
        {
            openInventoryButton.onClick.AddListener(OpenInventoryPanel);
            closeInventoryButton.onClick.AddListener(CloseInventoryPanel);
        }
        
        private void OpenInventoryPanel()
        {
            inventoryPanel.SetActive(true);
            
        }

        private void CloseInventoryPanel()
        {
            inventoryPanel.SetActive(false);
        }

        private void DisplayInventory()
        {
            // menampilkan semua elemt inventory
        }
    }
}
