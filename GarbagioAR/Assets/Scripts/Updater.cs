using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Updater : MonoBehaviour
{
    public GameObject BackgroundColourOb;
    public GameObject HeaderColourOb;
    public GameObject TextOb;

   

    // Update is called once per frame
    void Update()
    {
        GameObject go = GameObject.Find("CurrStatus");
        if (go == null)
        {
            Debug.LogError("Failed to find an object named CurrStatus");
            this.enabled = false;
            return;
        }
        CurrStatus cs = go.GetComponent<CurrStatus>();
        TextOb.GetComponent<Text>().fontSize = cs.FontSize;
        BackgroundColourOb.GetComponent<Image>().color = cs.BackgroundColour;
        HeaderColourOb.GetComponent<Image>().color = cs.HeaderColour;
        Debug.Log("INSIDEL Updater-> update");
        Debug.Log("FontSize: " + cs.FontSize);
        Debug.Log("BackgroundColour: " + cs.BackgroundColour);
        Debug.Log("HeaderColour: " + cs.HeaderColour);


    }
}
