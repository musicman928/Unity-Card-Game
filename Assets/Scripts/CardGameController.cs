using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGameController : MonoBehaviour {
    public static GameObject Instance;
    public GameObject PCardPrefab;
    public GameObject CardContainerPrefab;
    public GameObject PlayerBench;
    public GameObject PlayerHand;

    Card[] PlayerBenchCards = new Card[5];
    List<Card> PlayerHandCards = new List<Card>();

    void Awake() {
        
        Instance = gameObject;

        Instantiate(CardContainerPrefab, PlayerBench.transform);
        GameObject ocard = PlayerBench.transform.GetChild(0).gameObject;
        ocard.transform.localScale = new Vector3(0.656f, 0.656f, 0.656f);
        Instantiate(PCardPrefab, ocard.transform);
        //PlayerBench.transform.GetChild(0).GetComponent<RectTransform>.localScale.y = 
        //cardcontainer.scale = playerbench.globalheight / cardContainer.height; 
        int[] array = {0,1,2,3,4,5,6,7,8,9};
        
        Deck<int> deck = new Deck<int>();
    }

    void Start() {
        Instance = gameObject;
        



        
        

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
