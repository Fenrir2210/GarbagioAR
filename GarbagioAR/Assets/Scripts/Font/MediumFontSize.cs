using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MediumFontSize : MonoBehaviour
{

    public GameObject changeToMedium;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TextChange()
    {
        changeToMedium.GetComponent<Text>().text = "MEDIUM MEDIUM MEDIUM MEDIUM MEDIUM!";
        changeToMedium.GetComponent<Text>().fontSize = 22;
        //changingText.GetComponent<Text>().color = Color.magenta;

    }
}
