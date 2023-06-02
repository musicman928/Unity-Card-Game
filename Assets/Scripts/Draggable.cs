using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
    [HideInInspector] public Transform parentAfterDrag;
    static bool enable = true;
    public Image image;

    public static void Disable() {
        enable = false;
    }

    public static void Enable() {
        enable = true;
    }

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData) {
        image = GetComponent<Image>();
        Debug.Log("Begin Drag");
        if (enable) {
            parentAfterDrag = transform.parent;
            transform.SetParent(transform.root);
            transform.SetAsLastSibling();
            image.raycastTarget = false;
        } else {
            Debug.Log("Start Drag Disabled");
        }
    }

    void IDragHandler.OnDrag(PointerEventData eventData) {
        if (enable) {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(transform.position.x, transform.position.y, -9);
        } else {
            Debug.Log("Drag Disabled");
        }
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData) {
        Debug.Log("End Drag");
        if (enable) {
            //transform.position = new Vector3(transform.position.x, transform.position.y, 0);;
            transform.SetParent(parentAfterDrag);
            image.raycastTarget = true;
        } else {
            Debug.Log("End Drag Disabled");
        }
        
    }

    
}
