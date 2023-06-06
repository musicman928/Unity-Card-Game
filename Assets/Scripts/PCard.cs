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
    public int retreatCost;
    public List<Attack> attacks;
    public List<Ability> abilities;
    public PCardStages stage;
    public CardColors type;
    public CardColors weakness;
    public CardColors resistance;

    public PCard(string name, int hp, string set, int id, CardColors type, PCardStages stage, CardColors weakness, CardColors resistance, List<string> Tags) {
        Debug.Log("Constructing " + name + " " + set + " " + id);
        this.name = name;
        maxhp = hp;
        this.hp = hp;
        this.set = set;
        this.id = id;
        this.type = type;
        this.stage = stage;
        this.weakness = weakness;
        this.resistance = resistance;

        List<string> defaultTags = new List<string>();
        defaultTags.Add("card");
        defaultTags.Add("pcard");
        defaultTags.Add(Utility.FormatAllLower(this.type.ToString()));
        defaultTags.Add(Utility.FormatAllLower(this.stage.ToString()));
        defaultTags.Add(Utility.FormatAllLower("weak: " + this.weakness.ToString()));
        defaultTags.Add(Utility.FormatAllLower("res: " + this.resistance.ToString()));
        this.Tags.AddRange(defaultTags);
        this.Tags.AddRange(Tags);
    }
    public override GameObject GetPrefab() {
        return Resources.Load<GameObject>("Prefabs/PCard.prefab");
    }

    public PCard Clone() {
        return new PCard(name, hp, set, id, type, stage, weakness, resistance, Tags);
    }
}