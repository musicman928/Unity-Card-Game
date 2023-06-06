using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardArrayController : MonoBehaviour {
    CardGameController controller;
    public int size = 5;

    public float ChildScale = 0.656f;

    private GameObject[] array;
    [SerializeField] private GameObject cardContainer;
    void Start() {
        controller = transform.root.GetComponent<CardGameController>();
        array = new GameObject[size];

        for (int i = size - 1; i >= 0; i--) {
            Instantiate(controller.CardContainerPrefab, transform);
            array[i] = controller.PlayerBench.transform.GetChild(0).gameObject;
        }

        
    }

    // Update is called once per frame
    void Update() {
        
    }

    public GameObject GetChild(int index) {
        return array[index];
    }

    private void drawChildren() {
        transform.DetachChildren();
        for (int i = 0; i < array.Length; i++) {
            Instantiate(cardContainer, transform);
            array[i].transform.SetParent(transform.GetChild(i));
        }        
    }
}
