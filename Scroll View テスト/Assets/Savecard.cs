using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Savecard : MonoBehaviour
{
    public ArrayList decks = new ArrayList();
    public void OnClick()
    {
        
        GameObject Hand = GameObject.Find("Hand");
        foreach (Transform child in Hand.transform) {
            decks.Add( child.gameObject);
        }
        

    }
}
