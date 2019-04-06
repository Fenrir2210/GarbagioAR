using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseModal : MonoBehaviour
{
    private GameObject modalCanvas;

    // Start is called before the first frame update
    void Start()
    {
        modalCanvas = this.transform.parent.gameObject;
        Button thisButton = this.GetComponent<Button>(); //The exit button itself
        thisButton.onClick.AddListener(exitModal);
    }

    // Update is called once per frame
    private void exitModal()
    {
        modalCanvas.SetActive(false);
    }
}
