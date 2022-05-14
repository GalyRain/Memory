using UnityEngine;
using UnityEngine.Events;

namespace GamePlay
{
    public class Score : MonoBehaviour
    {
        private const int Add = 60;
        private const int Remove = -20;
        private int _value;
        [SerializeField] private IntEvent onUpdate = new IntEvent();

        public void RestartScore()
        {
            _value = 0;
            onUpdate.Invoke(_value);
            Debug.Log(_value);
        }

        public void AddRemove(bool addRemove)
        {
            _value += addRemove == true ? Add : Remove;
            if (_value < 0)
            {
                _value = 0;
            }
            onUpdate.Invoke(_value);
            Debug.Log(_value);
        }
    }
}

[System.Serializable] public class IntEvent : UnityEvent<int> { }