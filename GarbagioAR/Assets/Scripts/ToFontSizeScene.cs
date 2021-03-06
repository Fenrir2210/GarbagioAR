﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToFontSizeScene : MonoBehaviour
{

    private void Start()
    {
        Button thisButton = this.GetComponent<Button>();
        thisButton.onClick.AddListener(SceneChange);
    }

    private void SceneChange()
    {
        SceneManager.LoadScene("FontSizeScene", LoadSceneMode.Single);
    }

}

