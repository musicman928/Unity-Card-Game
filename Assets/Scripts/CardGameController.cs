using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(GameObject.Find("#PlayerBench") == null);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
