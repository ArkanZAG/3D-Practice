using UnityEngine;

namespace DefaultNamespace
{
    public interface IInteractable
    {
        public bool CanBeInteracted { get; }
        public Transform IndicatorPoint { get; }
        public void OnInteracted(GameObject interactor);
    }
}