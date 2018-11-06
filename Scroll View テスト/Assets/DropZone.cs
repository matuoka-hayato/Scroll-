using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler
{
    public static string location;
    static int TAG = 2;
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

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null)
        {
            d.parentToReturnTo = this.transform;
            if (location == "Hand")
            {
                TAG++;
                if (TAG >= 4)
                {
                    GetComponent<ContentSizeFitter>().verticalFit = ContentSizeFitter.FitMode.PreferredSize;
                }
                if (TAG <= 3)
                {
                    GetComponent<ContentSizeFitter>().verticalFit = ContentSizeFitter.FitMode.Unconstrained;
                }
            }
            else {
                TAG--;
                if (TAG <= 3)
                {
                    HandZone.GetComponent<ContentSizeFitter>().verticalFit = ContentSizeFitter.FitMode.Unconstrained;
                }
            }
            Debug.Log(TAG);
            
        }
    }

    public string Decision()
    {
        Debug.Log("あげたいのは" + location);
        return location;
    }

}

