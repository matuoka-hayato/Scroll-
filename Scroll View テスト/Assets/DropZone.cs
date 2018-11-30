using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler
{
    public static string location;
    public GameObject HandZone;

    public void OnPointerEnter(PointerEventData eventData)
    {

    }

    public void OnPointerExit(PointerEventData eventData)
    {

    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerDrag.name + "was droped on " + gameObject.name);
        location = gameObject.name;
        int HandCount = transform.childCount;


        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null)
        {
            d.parentToReturnTo = this.transform;
            if (location == "Hand")
            {
                Debug.Log(HandCount);
                if (HandCount <= 5)
                {
                    GetComponent<ContentSizeFitter>().verticalFit = ContentSizeFitter.FitMode.Unconstrained;
                }
                Debug.Log(HandCount);
                if (HandCount >= 6)
                {
                    GetComponent<ContentSizeFitter>().verticalFit = ContentSizeFitter.FitMode.PreferredSize;
                }
                
            }
            else {
                Debug.Log(HandCount);
                if (HandCount <= 5)
                {
                    HandZone.GetComponent<ContentSizeFitter>().verticalFit = ContentSizeFitter.FitMode.Unconstrained;
                }
            }
            
            
        }
    }

    public string Decision()
    {
        Debug.Log("あげたいのは" + location);
        return location;
    }

}

