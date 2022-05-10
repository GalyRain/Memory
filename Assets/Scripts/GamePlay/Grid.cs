using Assets;
using UnityEngine;

namespace GamePlay
{
    public class Grid : MonoBehaviour
    {
        public readonly float OffsetX = 2f;
        public readonly float OffsetY = 2f;
        public readonly float PositionY = 0.5f;

        [SerializeField] private LevelData _levelData = null;

        public int GetColumsCount()
        {
            return _levelData.MaxPlayCards;
        }

        public float GetPositionX()
        {
            float x = 1f;
            x -= GetColumsCount() % 2;
            x -= OffsetX * (GetColumsCount() / 2);
            return x;
        }
    }
}
