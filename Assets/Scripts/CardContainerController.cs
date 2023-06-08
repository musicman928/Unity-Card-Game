using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardContainerController : MonoBehaviour, IDropHandler {
    
    public Card ContainedCard;
    [SerializeField] GameObject ContainedObject;
    public bool Droppable;
    public string State;
    public List<string> ValidProperties;

    public void SetObject(GameObject contained) {
        ContainedObject = contained;
        transform.DetachChildren();
        ContainedObject.transform.SetParent(transform);
        
    }

    public void InstantiatePrefab(GameObject prefab) {
        transform.DetachChildren();
        Instantiate(prefab, transform);
        ContainedObject = transform.GetChild(0).gameObject;
        ContainedObject.transform.SetParent(transform);
        
    }

    public void InstantiateCard(Card card) {
        ContainedCard = card;
        transform.DetachChildren();
        Instantiate(card.GetPrefab(), transform);
        ContainedObject = transform.GetChild(0).gameObject;
        
        ContainedObject.transform.SetParent(transform);
        
    }

    public void OnDrop(PointerEventData eventData) {
        if (Droppable) {

            GameObject dropped = eventData.pointerDrag; 
            Draggable dragged = dropped.GetComponent<Draggable>();

            switch(State) {
                case "empty_bench":
                    bool valid = false;
                    foreach(string property in ValidProperties) {
                        if (Property.Contains(property, dropped)) {
                            valid = true;
                        }
                    }

                    
                break;

                case "empty_active":

                break;
            }


            
            dragged.parentAfterDrag = transform;
        }
        
    }

    
}
