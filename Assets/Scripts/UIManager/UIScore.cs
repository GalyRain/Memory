using TMPro;
using UnityEngine;

namespace UIManager
{
    public class UIScore : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI textScore = null;
 
        public void UpdateText(int value)
        {
            textScore.text = (value.ToString());
        }
    }
}