using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenUtils
{
    public static bool isPosition_on_screen(Vector3 pos){
        Vector3 converted = Camera.main.WorldToScreenPoint(pos);
        if (converted.x > 0 && converted.y > 0 && converted.x < Screen.width && converted.y < Screen.height){
            return true;
        }  
        return  false;
    }
}
