﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler
{
    public static string location;

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
        }
    }

    public string Decision()
    {
        Debug.Log("あげたいのは" + location);
        return location;
    }

}

