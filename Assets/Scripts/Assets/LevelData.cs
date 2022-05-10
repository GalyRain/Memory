using UnityEngine;

namespace Assets
{
    [CreateAssetMenu(fileName = "Level", menuName = "Assets/Level")]
    public class LevelData : ScriptableObject
    {
        public int MaxPlayCards;
        public string ThemeName;
    }
}
