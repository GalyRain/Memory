using Assets;
using UnityEngine;
using UnityEngine.UI;

namespace UIManager
{
    public class UISettings : MonoBehaviour
    {

        [SerializeField] private LevelData levelData = null;
        [SerializeField] private Button levelButton = null;
        [SerializeField] private Button themeButton = null;
    
        public void SetDifficult(int value)
        {
            levelData.maxPlayCards = value;
        }

        public void SetTheme(string name)
        {
            levelData.themeName = name;
        }

        public void OnEnable()
        {
            levelButton.onClick.Invoke();
            themeButton.onClick.Invoke();
        }
    }
}