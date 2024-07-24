using System;
using TMPro;
using UnityEngine;

namespace EXP_scene
{
    public class UI : MonoBehaviour
    {
        [SerializeField] private GameController gameController;
        [SerializeField] private TextMeshProUGUI experienceText;
        [SerializeField] private TextMeshProUGUI levelText;

        public void ShowExperience()
        {
            experienceText.text = gameController.CurrentExperience.ToString();
        }

        public void ShowLevel()
        {
            levelText.text = gameController.CurrentLevel.ToString();
        }

        private void Update()
        {
            ShowExperience();
            ShowLevel();
        }
    }
}