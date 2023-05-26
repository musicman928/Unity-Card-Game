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

    override public string ToString() {
        return name + " " + set + " " + id;
    }

    public static double getWidthMultiplier() {
        return 0.71428571428;
    }
}