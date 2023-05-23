using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGameController : MonoBehaviour
{
    public GameObject PCardPrefab;

    Card[] PlayerBenchCards = new Card[5];
    public GameObject PlayerBench;
    List<Card> PlayerHandCards = new List<Card>();
    public GameObject PlayerHand;

    // Start is called before the first frame update
    void Start() {
       Instantiate(PCardPrefab, transform);
    }

    // Update is called once per frame
    void Update() {
        
    }
}
