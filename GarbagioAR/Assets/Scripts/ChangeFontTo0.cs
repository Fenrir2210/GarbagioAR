using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeFontTo0 : MonoBehaviour
{


    private void Start()
    {
        Button thisButton = this.GetComponent<Button>(); 
        thisButton.onClick.AddListener(ChangeFont);
    }

   
    private void ChangeFont()
    {
        Globals.FontSize = 12;
        int CurrentFont = Globals.FontSize;
        Debug.Log("oi the current font size is: " + CurrentFont);
        Globals.FontSize = 14;
        int CurrentFont2 = Globals.FontSize;
        Debug.Log("oi the current font size is: " + CurrentFont2);
    }

}
