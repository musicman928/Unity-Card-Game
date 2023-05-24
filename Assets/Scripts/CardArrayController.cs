using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardArrayController : MonoBehaviour {
    public int size = 5;
    private GameObject[] array;
    [SerializeField] private GameObject cardContainer;
    void Start() {
        array = new GameObject[size];
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void AddChild(GameObject child, int index) {
        array[index] = child;
        
        drawChildren();
    }

    private void drawChildren() {
        transform.DetachChildren();
        foreach (GameObject i in array) {

            i.transform.SetParent(transform);
        }        
    }
}
