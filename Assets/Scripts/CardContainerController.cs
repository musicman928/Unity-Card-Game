using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardContainerController : MonoBehaviour {
    
    public Card ContainedCard;
    [SerializeField] GameObject ContainedObject;
    [SerializeField] GameObject pCardPrefab;

    public void SetObject(GameObject gameObject) {
        ContainedObject = gameObject;
        transform.DetachChildren();
        ContainedObject.transform.SetParent(transform);
        Debug.Log(ContainedObject.transform.GetComponent<RectTransform>().sizeDelta.y);
    }

    public void Hidden(bool hidden) {

    }

    public GameObject GetObject() {
        return ContainedObject;
    }


    
}
