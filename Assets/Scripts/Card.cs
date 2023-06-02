using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System;

public abstract class Card : ScriptableObject{
    public new string name;
    public string set;
    public int id;
    public List<string> Tags = new List<string>();

    override public string ToString() {
        return name + " " + set + " " + id;
    }

    public static double getWidthMultiplier() {
        return 0.71428571428;
    }

    public abstract GameObject GetPrefab();
}