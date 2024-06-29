using InteractionSystem;
using UnityEngine;

namespace DialogueSystem
{
    public class DialogueInteractable : MonoBehaviour, IInteractable
    {
        [SerializeField] private Dialogue dialogue;
        [SerializeField] private DialogueController dialogueController;
        public bool CanBeInteracted => !dialogueController.IsInDialogue;
        public Transform IndicatorPoint => transform;
        public void OnInteracted(GameObject interactor)
        {
            dialogueController.StartDialogue(dialogue);
        }

        public string IndicatorText => "Talk";
    }
}