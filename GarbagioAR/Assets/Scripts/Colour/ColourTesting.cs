using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourTesting : MonoBehaviour
{

    public GameObject BackgroundColour;
    public GameObject HeaderColour;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ColourChange()
    {
        BackgroundColour.GetComponent<Image>().color = new Color32(75, 102, 161, 255);
        HeaderColour.GetComponent<Image>().color = new Color32(51, 72, 130, 255); 
        //changingText.GetComponent<Text>().color = Color.magenta;

    }
}
