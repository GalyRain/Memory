using System.Collections.Generic;
using Assets;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

namespace GamePlay
{
    public class PresetCards : MonoBehaviour
    {
        private Sprite _backSprite = null;
        private List<Sprite> _allSprites = null;
        
        [SerializeField] private LevelData levelData = null;
        [SerializeField] private UnityEvent onLoad = new UnityEvent();
        
        private readonly ResourcesLoader _resourcesLoader = new ResourcesLoader();

        public void GetSprite()
        {
            Theme theme = _resourcesLoader.GetTheme(levelData.themeName);
            _backSprite = theme.backSprite;
            _allSprites = theme.allSprites;
            onLoad.Invoke();
        }
        
        public Sprite GetBackSprite()
        {
            return _backSprite;
        }

        public List<Sprite> GetPlayCardsSprites()
        {
            List<Sprite> sprites = new List<Sprite>(_allSprites);
            while (levelData.maxPlayCards < sprites.Count)
            {
                sprites.RemoveAt(Random.Range(0, sprites.Count));
            }
            return sprites;
        }

        public int[] GetCardIndex()
        {
            int[] cardIndex = new int[levelData.maxPlayCards * 2];
            for (int i = 0; i < cardIndex.Length; i++)
            {
                cardIndex[i] = i / 2;
            }

            for (int i = 0; i < cardIndex.Length; i++)
            {
                int temp = cardIndex[i];
                int random = Random.Range(0, cardIndex.Length);
                cardIndex[i] = cardIndex[random];
                cardIndex[random] = temp;
            }
            return cardIndex;
        }
    }
}