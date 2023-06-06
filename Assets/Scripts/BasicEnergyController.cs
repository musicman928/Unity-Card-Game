using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System;

public class BasicEnergyController : MonoBehaviour {
    public BasicEnergy card;
    public GameObject root;
    public TextMeshProUGUI nameText;
    public Image color;

    public void DrawCard() {
        if (card != null) {
            nameText.text = Utility.Format(card.name);
            color.sprite = Resources.Load<Sprite>("Sprites/" + card.EnergyValue.ToString().ToLower() + "_energy.png");
            
        }

    }
}