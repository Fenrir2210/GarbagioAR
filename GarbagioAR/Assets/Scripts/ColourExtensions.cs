using System;
using UnityEngine;
// Melina Laird - CS4474

// class to convert strings to color32
// used in CurrStatus:ChangeHeaderColour and CurrStatus:ChangeBackgroundColour
// split into string array by the comma
// trim spaces and convert to an int
// convert to a byte array
// create and return colour/color
public class ColourExtensions
{
    public Color32 FromString(string rgbString)
    {
        string[] colours = rgbString.Split(',');
        int rint = Int32.Parse(colours[0].Trim());
        int gint = Int32.Parse(colours[1].Trim());
        int bint = Int32.Parse(colours[2].Trim());
        int aint = Int32.Parse(colours[3].Trim());
        byte[] r = BitConverter.GetBytes(rint);
        byte[] g = BitConverter.GetBytes(gint);
        byte[] b = BitConverter.GetBytes(bint);
        byte[] a = BitConverter.GetBytes(aint);
        Color32 rbgColour = new Color32(r[0], g[0], b[0], a[0]);
        return rbgColour;
    }
}
