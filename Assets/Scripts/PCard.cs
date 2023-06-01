using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System;

[CreateAssetMenu(fileName = "New PCard", menuName = "PCard")]
public class PCard : Card {
    
    public int maxhp;
    public int hp;
    public List<Action> actions;
    public CardColors type;
    public PCardStages stage;
    public int retreatCost;
    public CardColors weakness;
    public CardColors resistance;

    public PCard(string name, int hp, string set, int id, List<string> properties, List<Action> actions) {

        this.name = name;
        maxhp = hp;
        this.hp = hp;
        this.set = set;
        this.id = id;
        this.actions = actions;


    }

    public override GameObject GetPrefab() {
        return Resources.Load<GameObject>("Prefabs/PCard.prefab");
    }
}