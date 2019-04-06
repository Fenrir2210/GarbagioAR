using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CurrStatus : MonoBehaviour
{
    public Color32 BackgroundColour = new Color32(75, 102, 161, 255);
    public Color32 HeaderColour = new Color32(51, 72, 130, 255);
    public int FontSize = 22;

    static CurrStatus instance;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("STARTING");
        Debug.Log("current instance=" + instance);
        Debug.Log("This: " + this);
        if (instance != null)
        {
            //there is already an instance of status, self destory
            Debug.Log("Destroying Object: " +this);
            Destroy(this);
            return;
        }
        //GameObject go = GameObject.Find("CurrStatus");
        //status = go.GetComponent<CurrStatus>();
        instance = this;
        DontDestroyOnLoad(this.gameObject);
        Debug.Log("THIS IS THE END OF THE START");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeFont(int NewFontSize)
    {
        instance.FontSize = NewFontSize;
    }

    public void ChangeBackgroundColour(string NewBackgroundColourString)
    {
        ColourExtensions col = new ColourExtensions();
        Color32 NewColour = col.FromString(NewBackgroundColourString);
        instance.BackgroundColour = NewColour;
        Debug.Log("Oi cunt want soem fuck?!?! ONe");
    }

    public void ChangeHeaderColour(string NewHeaderColourString)
    {
        ColourExtensions col = new ColourExtensions();
        Color32 NewColour = col.FromString(NewHeaderColourString);
        instance.HeaderColour = NewColour;
        Debug.Log("header colour: " + HeaderColour);
        Debug.Log("Oi cunt want soem fuck?!?! TWO");
        

    }

    private void OnDestroy()
    {
        Debug.Log("a version of CurrStatus was was destroyed!!!");
    }

    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);

    }
}
