using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenColourScheme : MonoBehaviour
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
        BackgroundColour.GetComponent<Image>().color = new Color32(71, 138, 75, 255);
        HeaderColour.GetComponent<Image>().color = new Color32(48, 97, 51, 255);
        //changingText.GetComponent<Text>().color = Color.magenta;

    }
}
