using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CurrStatus : MonoBehaviour
{
    static CurrStatus status;
    public Color32 BackgroundColour = new Color32(75, 102, 161, 255);
    public Color32 HeaderColour = new Color32(51, 72, 130, 255);
    public int FontSize = 22;
  




    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("STARTING");
        Debug.Log("status=" + status);
        //if (status != null)
        //{
        //    //there is already an instance of font size, self destory
        //    Destroy(this.gameObject);
        //    Debug.Log("object destoryed: " + this.gameObject);
        //    return;
        //}
        GameObject go = GameObject.Find("CurrStatus");
        status = this;
        DontDestroyOnLoad(go);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeFont(int NewFontSize)
    {
        FontSize = NewFontSize;
    }

    public void ChangeBackgroundColour(string NewBackgroundColourString)
    {
        ColourExtensions col = new ColourExtensions();
        Color32 NewColour = col.FromString(NewBackgroundColourString);
        BackgroundColour = NewColour;
        Debug.Log("Oi cunt want soem fuck?!?! ONe");
    }

    public void ChangeHeaderColour(string NewHeaderColourString)
    {
        ColourExtensions col = new ColourExtensions();
        Color32 NewColour = col.FromString(NewHeaderColourString);
        HeaderColour = NewColour;
        Debug.Log("Oi cunt want soem fuck?!?! TWO");
    

    }

    //private void OnDestroy()
    //{
    //    Debug.Log("CurrStatus was destroyed");
    //}

    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);

    }
}
