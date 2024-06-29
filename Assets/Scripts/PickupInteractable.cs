using UnityEngine;

namespace DefaultNamespace
{
    public class PickupInteractable : MonoBehaviour, IInteractable
    {
        [SerializeField] private string itemId;
        [SerializeField] private GameObject visual;

        public bool CanBeInteracted { get; private set; } = true;
        public Transform IndicatorPoint => transform;

        public void OnInteracted(GameObject interactor)
        {
            var inventory = interactor.GetComponent<PlayerInventory>();
            inventory.Add(itemId);
            visual.SetActive(false);
            CanBeInteracted = false;
        }
    }
}