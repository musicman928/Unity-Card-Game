using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    [SerializeField] private GameObject PrefabToInstantiate;
    
    public static HandController Instance;
    RectTransform rectTransform;

    void Awake(){
        Instance = this;
    }

    void Start() {
        //Instantiate(PrefabToInstantiate, transform);
        
    }

    
    void Update() {
        //Math.Lerp()
    }

    void OnMouseEnter(){
        transform.localPosition = new Vector3(0, -405, 0);
    }

    void OnMouseExit() {
        transform.localPosition = new Vector3(0, -512, 0);
    }

    // public void AddCard(Card in) {
        
    // }
}
