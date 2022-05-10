using TMPro;
using UnityEngine;

namespace UIManager
{
    public class UIScore : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text = null;

        private void Awake()
        {
            _text = GetComponent<TextMeshProUGUI>();
        }

        public void UpdateText(int? value)
        {
            _text.text = ((int?)null).ToString();
        }
    }
}
