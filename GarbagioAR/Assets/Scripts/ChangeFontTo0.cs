using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeFontTo0 : MonoBehaviour
{

    private void Start()
    {
        int CurrentFont = Globals.FontSize;
        Debug.Log("oi the current font size is: " + CurrentFont);

        Button thisButton = this.GetComponent<Button>();
        thisButton.onClick.AddListener(SceneChange);
    }

    private void SceneChange()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

}
