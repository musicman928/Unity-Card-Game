using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour {

    CardGameController controller;

    void Start() {
        controller = transform.root.GetComponent<CardGameController>();
    }

    // Update is called once per frame
    void Update() {
        
    }

}
