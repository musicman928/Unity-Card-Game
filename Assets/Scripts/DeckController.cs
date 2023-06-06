using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeckController : MonoBehaviour {

    CardGameController controller;
    Deck<Card> deck = new Deck<Card>();

    void Awake() {
        controller = transform.root.GetComponent<CardGameController>();
    }
    
    void Start() {
        BasicEnergy yellow = new BasicEnergy(CardColors.YELLOW);
        AddToTop(yellow);
        DrawToHand();
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnModified() {
        transform.GetComponentInChildren<TextMeshProUGUI>().text = GetLength().ToString();
    }

    public void DrawToHand() {
        controller.PlayerHand.GetComponent<HandController>().AddCard(deck.Draw());
        OnModified();
    }

    public int GetLength() {
        return deck.GetLength();
    }

    public void AddToTop(Card item) {
        deck.AddToTop(item);
        OnModified();
    }
}
