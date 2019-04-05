using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Globals
{
    private static int _fontSize;
    private static Color _mainColor;
    private static Color _topColor;
  
    public static int FontSize{
        get{
            return _fontSize;
        }
        set{
            _fontSize = value;
        }
    }
    public static Color mainColor {
        get{
            return _mainColor;
        }
        set{
            _mainColor = value;
        }
    }
    public static Color topColor {
        get{
            return _topColor;
        }
        set{
            _topColor = value;
        }
    }
    
}

