using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class deckfinish : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("deckEdit");
    }
}
