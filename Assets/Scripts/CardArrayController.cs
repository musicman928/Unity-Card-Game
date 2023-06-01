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
        controller = CardGameController.Instance;
        array = new GameObject[size];
        Instantiate(controller.CardContainerPrefab, transform);
        GameObject ocard = controller.PlayerBench.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void AddChild(GameObject child, int index) {
        array[index] = child;
        
        drawChildren();
    }

    public void RemoveChild(int index) {
        
    }

    private void drawChildren() {
        transform.DetachChildren();
        for (int i = 0; i < array.Length; i++) {
            Instantiate(cardContainer, transform);
            array[i].transform.SetParent(transform.GetChild(i));
        }        
    }
}
