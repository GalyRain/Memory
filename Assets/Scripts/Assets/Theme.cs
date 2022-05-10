using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    [CreateAssetMenu(fileName = "Theme", menuName = "Assets/Theme")]
    public class Theme : ScriptableObject
    {
        public Sprite BackSprite;
        public List<Sprite> AllSprites;
    }
}
