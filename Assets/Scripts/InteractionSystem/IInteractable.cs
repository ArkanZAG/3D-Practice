using UnityEngine;

namespace InteractionSystem
{
    public interface IInteractable
    {
        public bool CanBeInteracted { get; }
        public Transform IndicatorPoint { get; }
        public void OnInteracted(GameObject interactor);
        public string IndicatorText { get; }
    }
}