using UnityEngine;

namespace DialogueSystem
{
    public class DialogueTestScript : MonoBehaviour
    {
        [SerializeField] private DialogueController dialogueController;
        [SerializeField] private Dialogue firstDialogue;
        [SerializeField] private Dialogue secondDialogue;
        [SerializeField] private Dialogue thirdDialogue;

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                dialogueController.StartDialogue(firstDialogue);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                dialogueController.StartDialogue(secondDialogue);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                dialogueController.StartDialogue(thirdDialogue);
            }
        }
        
    }
}
