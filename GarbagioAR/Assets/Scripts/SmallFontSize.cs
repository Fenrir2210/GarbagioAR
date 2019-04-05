using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmallFontSize : MonoBehaviour
{

    public GameObject changeToSmall;
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
        changeToSmall.GetComponent<Text>().text = "SMOL SMOL SMOL SMOL SMOL!";
        changeToSmall.GetComponent<Text>().fontSize = 14;
        //changingText.GetComponent<Text>().color = Color.magenta;

    }
}