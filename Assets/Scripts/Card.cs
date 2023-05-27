using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System;

public abstract class Card : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
    protected string set;
    protected int id;
    public List<string> Tags;

    override public string ToString() {
        return name + " " + set + " " + id;
    }

    public static double getWidthMultiplier() {
        return 0.71428571428;
    }

    public abstract void Draw(GameObject drawTo);

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
}