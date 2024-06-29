using TMPro;
using UnityEngine;
using Button = UnityEngine.UI.Button;
using Image = UnityEngine.UI.Image;

namespace DialogueSystem
{
    public class TextBox : MonoBehaviour
    {
        [SerializeField] private Image backGround;
        [SerializeField] private Button nextButton;
        [SerializeField] private TextMeshProUGUI nameText;
        [SerializeField] private TextMeshProUGUI contentText;

        public void ShowDialogueEntry (DialogueEntry entry)
        {
            backGround.sprite = entry.backgroundSprite;
            nameText.text = entry.name;
            contentText.text = entry.content;
        }
    }
}
