using System;
using UnityEngine;
using UnityEngine.UI;
// Melina Laird - CS4474

public class Updater : MonoBehaviour
{
    // Drag and drop the game object into these variable spaces in the 
    // inspector under the main canvas
    public GameObject BackgroundColourOb;
    public GameObject HeaderColourOb;
    public GameObject TextOb;

    // Update is called once per frame
    // Access the currentStatus (colours and font) and sets the header, background, and font size
    void Update()
    {
        GameObject go = GameObject.Find("CurrStatus");
        // make sure we have a CurrStatus GameObject
        if (go == null)
        {
            Debug.LogError("Failed to find an object named CurrStatus");
            this.enabled = false;
            return;
        }
        CurrStatus cs = go.GetComponent<CurrStatus>();
        // case 1 : GameObject TextOb is a single gameObject of type text
        // access text component and edit it 
        try
        {
            TextOb.GetComponent<Text>().fontSize = cs.FontSize;
        }
        // case 2 : GameObject TextOb is an Empty with multiple text object children
        // this is the case in Tutorial, where all boxes of text should change size
        // access the children of type text and itterate through them, changing the font size
        catch (NullReferenceException)
        {
            Text[] textList = TextOb.GetComponentsInChildren<Text>();
            for (int i = 0; i < textList.Length; i++)
            {
                textList[i].GetComponent<Text>().fontSize = cs.FontSize;
            }
        }
        // Only one case for colours, just change them.
        BackgroundColourOb.GetComponent<Image>().color = cs.BackgroundColour;
        HeaderColourOb.GetComponent<Image>().color = cs.HeaderColour;
    }
}
