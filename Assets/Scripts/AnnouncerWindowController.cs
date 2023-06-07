using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnnouncerWindowController : MonoBehaviour {
    Animator animator;

    // Start is called before the first frame update
    void Start() {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void Announce(string text) {
        GetComponentInChildren<TextMeshProUGUI>().text = text;
        animator.SetTrigger("Announcement");
    }
}
