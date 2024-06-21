using TMPro;
using UnityEngine;

namespace DefaultNamespace
{

    public class PlayerInventoryUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI coinText;


        public void UpdateItems(int coin)
        {
            coinText.text = "Coins: " + coin;
        }
    }
}