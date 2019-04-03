using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpenStatistics : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Button thisButton = this.GetComponent<Button>();
        thisButton.onClick.AddListener(SceneChange);
    }

    // Update is called once per frame
    private void SceneChange ()
    {
        SceneManager.LoadScene("StatisticsScene", LoadSceneMode.Single);
    }
}
