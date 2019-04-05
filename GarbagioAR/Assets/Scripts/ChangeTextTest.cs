using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTextTest : MonoBehaviour
{

    public GameObject changingText;
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
        changingText.GetComponent<Text>().text = "FUCKIN YEET!";
        changingText.GetComponent<Text>().fontSize = 45;

    }
}
