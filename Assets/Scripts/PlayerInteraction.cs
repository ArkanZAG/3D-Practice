using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class PlayerInteraction : MonoBehaviour
    {
        [SerializeField] private GameObject interactionIndicator;
        [SerializeField] private float interactionRange = 5f;

        private void Update()
        {
            var nearestInteractable = GetNearestInteractable();
            interactionIndicator.SetActive(nearestInteractable != null);
            if (nearestInteractable == null) return;
            interactionIndicator.transform.position = nearestInteractable.IndicatorPoint.position;
            
            if (Input.GetKeyDown(KeyCode.E)) nearestInteractable.OnInteracted(this.gameObject);
        }

        private IInteractable GetNearestInteractable()
        {
            var colliders = Physics.OverlapSphere(transform.position, interactionRange);
            var nearest = float.MaxValue;
            IInteractable nearestInteractable = null;
            foreach (var col in colliders)
            {
                var interactable = col.GetComponent<IInteractable>();
                if (interactable == null) continue;

                if (!interactable.CanBeInteracted) continue;

                var distance = Vector3.Distance(col.transform.position, transform.position);
                if (distance > nearest) continue;
                nearest = distance;
                nearestInteractable = interactable;
            }

            return nearestInteractable;
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, interactionRange);
        }
    }
}