using System;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;
using UnityEngine.UI;

namespace InventorySystem
{
    public class InventoryView : MonoBehaviour
    {
        [SerializeField] private Button openInventoryButton;
        [SerializeField] private Button closeInventoryButton;
        [SerializeField] private GameObject inventoryPanel;

        [SerializeField] private GameObject inventoryElement;
        [SerializeField] private GameObject elementParent;
        
        [SerializeField] private Inventory inventory;

        [SerializeField] private List<GameObject> spawnedElements = new();

        private void Start()
        {
            openInventoryButton.onClick.AddListener(OpenInventoryPanel);
            closeInventoryButton.onClick.AddListener(CloseInventoryPanel);
        }
        private void OpenInventoryPanel()
        {
            inventoryPanel.SetActive(true);
            DisplayInventory();
        }
        private void CloseInventoryPanel()
        {
            inventoryPanel.SetActive(false);
            ClearInventory();
        }
        private void DisplayInventory()
        {
            for (var i = 0; i < inventory.Items.Count; i++)
            {
                var obj = Instantiate(inventoryElement, elementParent.transform, false);
                var inventoryViewElement = obj.GetComponent<InventoryViewElement>();
                inventoryViewElement.Show(inventory.Items[i]);
                spawnedElements.Add(obj);
            }
        }
        private void ClearInventory()
        {
            for (int i = 0; i < spawnedElements.Count; i++)
            {
                Destroy(spawnedElements[i]);
            }
            spawnedElements.Clear();
        }
    }
}
