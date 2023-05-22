using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour {
    
    private static GameObject controller;

    void Start() {
        controller = gameObject;
    }

    // Update is called once per frame
    void Update() {
        
    }

    public static GameObject get() {
        return controller;
    }
}
