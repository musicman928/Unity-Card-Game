using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CardGameController : MonoBehaviour {
    public GameObject PCardPrefab;
    public GameObject CardContainerPrefab;
    public GameObject PlayerBench;
    public GameObject PlayerHand;
    public delegate void GameUpdate();
    public static GameUpdate OnUpdate;
    

    Card[] PlayerBenchCards = new Card[5];
    List<Card> PlayerHandCards = new List<Card>();

    void Start() {
        
        //PCardController cardcontroller = ocard.GetComponent<CardContainerController>().GetComponentInChildren<PCardController>();
        //PCard cardinstance = (PCard)AssetDatabase.LoadAssetAtPath("Assets/Resources/Cards/PCards/Miraidon_ex.asset", typeof(PCard));
        //cardcontroller.SetCard(cardinstance);
        //PlayerBench.transform.GetChild(0).GetComponent<RectTransform>.localScale.y = 
        //cardcontainer.scale = playerbench.globalheight / cardContainer.height; 
        int[] array = {0,1,2,3,4,5,6,7,8,9};
        
        Deck<int> deck = new Deck<int>();
        



        
        

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

    public void CallUpdate() {
        OnUpdate();
    }

    
}
