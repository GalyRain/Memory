using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace GamePlay
{
    public class CardSpawner : MonoBehaviour
    {
        [SerializeField] private Grid grid = null;
        [SerializeField] private PresetCards presetCards = null;
        [SerializeField] private Card cardPrefab = null;
        [SerializeField] private UnityEvent startCollect = new UnityEvent();
        
        public void Spawn()
        {
            Transform localTransform = GetComponent<Transform>();
            Card card;
            Sprite backSprite = presetCards.GetBackSprite();
            List<Sprite> playCardsSprites = presetCards.GetPlayCardsSprites();
            
            int[] playCardsIndex = presetCards.GetCardIndex();
            float positionX = grid.GetPositionX();
            float positionY = grid.PositionY;
            int count = grid.GetColumsCount();

            for (int j = 0; j < playCardsIndex.Length; j++)
            {
                card = Instantiate(cardPrefab) as Card;
                card.transform.position = new Vector3(positionX, positionY + localTransform.position.y);
                card.transform.parent = localTransform;
                card.CardsSettings(backSprite, playCardsSprites[playCardsIndex[j]], playCardsIndex[j]);
                positionX += grid.OffsetX;
                count--;
                if (count < 1)
                {
                    count = grid.GetColumsCount();
                    positionY -= grid.OffsetY;
                    positionX = grid.GetPositionX();
                }
            }
            startCollect.Invoke();
        }
    }
}