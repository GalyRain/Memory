using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    [CreateAssetMenu(fileName = "Theme", menuName = "Assets/Theme")]
    public class Theme : ScriptableObject
    {
        public Sprite backSprite;
        public List<Sprite> allSprites;
    }
}