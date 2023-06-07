using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinFlipPromptController : MonoBehaviour {
    public Button HeadsButton;
    public Button TailsButton;
    public Transform Coin;
    private Animator coinAnimator;

    

    // Start is called before the first frame update
    void Start() {
        coinAnimator = Coin.GetComponent<Animator>();

        CheckFirstTurn();
    }

    void OnEnable() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    void ShowChildren() {
        foreach(Transform child in transform) {
            child.gameObject.SetActive(true);
        }
    }

    void HideChildren() {
        foreach(Transform child in transform) {
            child.gameObject.SetActive(false);
        }
    }

    public void CheckFirstTurn() {
        ShowChildren();

        bool output;
        

        HeadsButton.onClick.AddListener(() => {
            
            Debug.Log("Heads Pressed");
            
            StartCoroutine(CoinFlipAnimationStart(true));
            
        });

        TailsButton.onClick.AddListener(() => {
            
            Debug.Log("Tails Pressed");
            
            StartCoroutine(CoinFlipAnimationStart(false));
            
            
        });

    }

    public IEnumerator CoinFlipAnimationStart(bool guess) {
        
        bool result = Flip();

        if (result) {
            coinAnimator.SetTrigger("PlayHeads");
            
        } else {
            coinAnimator.SetTrigger("PlayTails");
        }
        Debug.Log("Started Flip Animation");
        

        Debug.Log("Waiting...");
        yield return new WaitForSeconds(2);
        Debug.Log("Done.");
        if (guess == result) {
            Debug.Log("Guessed right");
        } else {
            Debug.Log("Guessed wrong");
        }
        

        transform.root.GetComponent<CardGameController>().StartGame(result == guess);
        HideChildren();
        
    }



    public bool Flip() {
        // Heads = 1, Tails = 0

        int result = Random.Range(0, 2);

        return result == 1;
    }
}
