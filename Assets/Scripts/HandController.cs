using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour {
    CardGameController controller;
    RectTransform rectTransform;
    Vector3 rootPosition;

    void Awake() {
        controller = transform.root.GetComponent<CardGameController>();
    }

    void Start() {
        //Instantiate(PrefabToInstantiate, transform);
        rootPosition = transform.position;
    }

    
    void Update() {
        //Math.Lerp()
    }

    void OnMouseEnter(){
        transform.localPosition = new Vector3(rootPosition.x, rootPosition.y + 107, rootPosition.z);
    }

    void OnMouseExit() {
        transform.localPosition = rootPosition;
    }

    public void AddCard(Card card) {
        Instantiate(controller.CardContainerPrefab, transform);
        transform.GetChild(0).GetComponent<CardContainerController>().InstantiateCard(card);
    }
}
