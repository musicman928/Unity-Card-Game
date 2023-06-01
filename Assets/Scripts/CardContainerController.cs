using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardContainerController : MonoBehaviour {
    
    public Card ContainedCard;
    [SerializeField] GameObject ContainedObject;
    [SerializeField] GameObject pCardPrefab;

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

    public void RemoveObject() {
        ContainedObject = null;
        transform.DetachChildren();
    }

    void OnTransformChildrenChanged() {
        foreach(Transform child in transform) {
            child.transform.localPosition = new Vector3(0,0,0);
        }
    }

    public void Hidden(bool hidden) {

    }

    public GameObject GetObject() {
        return ContainedObject;
    }


    
}
