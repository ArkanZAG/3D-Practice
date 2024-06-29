using InteractionSystem;
using UnityEngine;

namespace DialogueSystem
{
    public class DialogueController : MonoBehaviour
    {
        [SerializeField] private Dialogue currentDialogue;
        [SerializeField] private int currentDialogueIndex;
        [SerializeField] private TextBox textBox;
        private bool isInDialogue = false;

        public bool IsInDialogue => isInDialogue;

        public void StartDialogue(Dialogue dialogue)
        {
            isInDialogue = true;
            textBox.gameObject.SetActive(true);
            currentDialogue = dialogue;
            textBox.ShowDialogueEntry(currentDialogue.entries[0]);
            currentDialogueIndex = 0;
        }

        public void ContinueDialogue()
        {
            Debug.Log("button Pressed");
            currentDialogueIndex += 1;
            Debug.Log(currentDialogueIndex);
            if (currentDialogueIndex >= currentDialogue.entries.Count)
            {
                StopDialogue(); 
                return;
            }
            textBox.ShowDialogueEntry(currentDialogue.entries[currentDialogueIndex]);
        }

        public void StopDialogue()
        {
            textBox.gameObject.SetActive(false);
            isInDialogue = false;
        }
    }
}