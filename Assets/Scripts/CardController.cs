using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System;

public class Card {
    protected string name;
    protected string set;
    protected int id;
    public string getFullName() {
        return name + " " + set + " " + id;
    }

    public static double getWidthMultiplier() {
        return 0.71428571428;
    }
}

public class PCard : Card {
    
    List<Action> actions;
    public PCard(string name, string set, int id, List<Action> actions) {

        this.name = name;
        this.set = set;
        this.id = id;
        this.actions = actions;

    }

    public void Draw(string drawto) {
        if (drawto == "PlayerBench") {
            Debug.Log(GameObject.Find("PlayerBench") == null);
        }
    }
}



public class CardController : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        PCard pcard = new PCard("Fred", "SUS", 1, null);
        Debug.Log(pcard.getFullName());
        
    }

    // Update is called once per frame
    void Update() {
        
    }
}
