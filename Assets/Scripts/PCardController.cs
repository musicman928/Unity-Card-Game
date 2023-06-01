using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System;

public class PCardController : MonoBehaviour {
    public PCard card;
    public GameObject root;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI stageText;
    public Image color;
    public TextMeshProUGUI retreatText;
    public Image weaknessImage;
    public Image resistanceImage;

    [SerializeField] [Range(0,50)] float maximumMovementSpeed;
    
    public void SetCard(PCard card) {
        this.card = card;
        DrawCard();
    }

    public PCard GetCard() {
        return card;
    }

    void Start() {
        root = transform.Find("Root").gameObject;
        nameText = root.transform.Find("Name").gameObject.GetComponent<TextMeshProUGUI>();
        stageText = root.transform.Find("Stage").gameObject.GetComponent<TextMeshProUGUI>();
        color = root.transform.Find("Color").gameObject.GetComponent<Image>();
        retreatText = root.transform.Find("Retreat").gameObject.GetComponent<TextMeshProUGUI>();
        weaknessImage = root.transform.Find("Weakness Color").gameObject.GetComponent<Image>();
        resistanceImage = root.transform.Find("Resistance Color").gameObject.GetComponent<Image>();

        
        
        if (card != null) {
            DrawCard();
        }
    }

    void DrawCard() {
        Debug.Log(card == null);
        nameText.text = Utility.Format(card.name);
        stageText.text = Utility.Format(card.stage.ToString());
        color.sprite = Resources.Load<Sprite>("Sprites/" + card.type.ToString().ToLower() + "_energy.png");
        retreatText.text = "Retreat: " + card.retreatCost;
        weaknessImage.sprite = Resources.Load<Sprite>("Sprites/" + card.weakness.ToString().ToLower() + "_energy.png");
        resistanceImage.sprite = Resources.Load<Sprite>("Sprites/" + card.resistance.ToString().ToLower() + "_energy.png");

    }

    
    void Update() {
        
    }
}
