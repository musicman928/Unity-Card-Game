using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System;


public class Card {
    protected string name;
    protected string set;
    protected int id;
    public List<string> Tags;
    public string getFullName() {
        return name + " " + set + " " + id;
    }

    public static double getWidthMultiplier() {
        return 0.71428571428;
    }
}

public class PCard : Card {
    
    int maxhp;
    int hp;
    List<Action> actions;
    public PCard(string name, int hp, string set, int id, List<Action> actions) {

        this.name = name;
        maxhp = hp;
        this.hp = hp;
        this.set = set;
        this.id = id;
        this.actions = actions;


    }

    public void Draw(GameObject drawTo) {
        
    }
}



public class PCardController : MonoBehaviour {
    public Card card;
    public GameObject root;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI stageText;
    public Image color;
    public TextMeshProUGUI retreatText;
    public Image weaknessImage;
    public Image resistanceImage;

    [SerializeField] [Range(0,50)] float maximumMovementSpeed;
    
    void Start() {
        root = transform.Find("Root").gameObject;
        nameText = root.transform.Find("Name").gameObject.GetComponent<TextMeshProUGUI>();
        stageText = root.transform.Find("Stage").gameObject.GetComponent<TextMeshProUGUI>();
        color = root.transform.Find("Color").gameObject.GetComponent<Image>();
        retreatText = root.transform.Find("Retreat").gameObject.GetComponent<TextMeshProUGUI>();
        weaknessImage = root.transform.Find("Weakness Color").gameObject.GetComponent<Image>();
        resistanceImage = root.transform.Find("Resistance Color").gameObject.GetComponent<Image>();

        
        
        
    }

    
    void Update() {
        
    }
}
