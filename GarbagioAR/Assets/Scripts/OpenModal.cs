using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenModal : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == "Quad")
            {
                //hit.collider.gameObject now refers to the 
                //quad under the mouse cursor if present
                if (Input.GetMouseButtonDown(0))
                    GameObject.Find("DetailModalCanvas").SetActive(true);


            }
        }
    }
}
