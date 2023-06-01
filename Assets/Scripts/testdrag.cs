using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class testdrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
}
