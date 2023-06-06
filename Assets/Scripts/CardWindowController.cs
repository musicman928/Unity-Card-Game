using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardWindowController : MonoBehaviour {
    
    public Card ContainedCard;

    void Start() {
        CardGameController.OnUpdate += DrawCard;
    }

    public void SetCard(Card ContainedCard) {
        this.ContainedCard = ContainedCard;
        DrawCard();
    }

    public void DrawCard() {
        transform.DetachChildren();
        Instantiate(ContainedCard.GetPrefab(), transform);
    }

    public void RemoveCard() {
        Destroy(gameObject);
    }
    
}
