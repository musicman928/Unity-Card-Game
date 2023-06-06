using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
[CreateAssetMenu(fileName = "New Card", menuName = "Cards/Card")]
public class CardType : ScriptableObject
{
    public event CardPlaced OnCardPlaced;


    public List<CardEffect> onCardPlacedEffects;
    public List<CardEffect> onCardActivate;

    public delegate void CardPlaced();
}
