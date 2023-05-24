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
       Instantiate(PCardPrefab, PlayerHand.transform);
    }

    // Update is called once per frame
    void Update() {
        
    }

    public GameObject[] GetChildrenWithTag(string tag, GameObject parent) {
        List<GameObject> output = new List<GameObject>();
        GameObject[] source = Property.GetAll(tag);

        foreach (GameObject element in source) {
            if (element.transform.IsChildOf(parent.transform)) {
                output.Add(element);
            }
        }

        return output.ToArray();
    }
}
