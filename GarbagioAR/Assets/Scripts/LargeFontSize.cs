using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LargeFontSize : MonoBehaviour
{

    public GameObject changeToLarge;
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
        changeToLarge.GetComponent<Text>().text = "BIG BEEFY BOI BIG BEEFY BOI!";
        changeToLarge.GetComponent<Text>().fontSize = 28;
        //changingText.GetComponent<Text>().color = Color.magenta;

    }
}
