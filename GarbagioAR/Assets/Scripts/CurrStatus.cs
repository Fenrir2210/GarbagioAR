using UnityEngine;
using UnityEngine.SceneManagement;
// Melina Laird - CS4474


public class CurrStatus : MonoBehaviour
{
    // Default values for the colours and font sizes, (blue, dark blue, and 22)
    public Color32 BackgroundColour = new Color32(75, 102, 161, 255);
    public Color32 HeaderColour = new Color32(51, 72, 130, 255);
    public int FontSize = 22;

    // Static instace of CurrStatus, we only want the one
    static CurrStatus instance;

    // Start is called before the first frame update
    void Start()
    {
        // check if there is already an instance of CurrStatus
        if (instance != null)
        {
            // there is already an instance of status, self destory
            Destroy(this);
            return;
        }
        // If there is not, become the CurrStatus and become indestructable
        // Unity Singleton Design Pattern
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    // Given font size, update font size which will be taken and used in Updater
    public void ChangeFont(int NewFontSize)
    {
        instance.FontSize = NewFontSize;
    }

    // Given background colour, update background colour which will be taken and used in Updater
    // Call Colour Extensions to convert String to a Color32 type
    public void ChangeBackgroundColour(string NewBackgroundColourString)
    {
        ColourExtensions col = new ColourExtensions();
        Color32 NewColour = col.FromString(NewBackgroundColourString);
        instance.BackgroundColour = NewColour;
    }

    // Given header colour, update header colour which will be taken and used in Updater
    // Call Colour Extensions to convert String to a Color32 type
    public void ChangeHeaderColour(string NewHeaderColourString)
    {
        ColourExtensions col = new ColourExtensions();
        Color32 NewColour = col.FromString(NewHeaderColourString);
        instance.HeaderColour = NewColour;
    }

    // attach to buttons to load new Scene, feeding in scene name
    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);

    }
}
