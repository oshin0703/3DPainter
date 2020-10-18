using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capture : MonoBehaviour
{   
    public void onclick(){ 
        Cursor.visible = false;
        GameObject canvas = GameObject.Find("Canvas");
        canvas.SetActive(false);
        ScreenCapture.CaptureScreenshot("Application.dataPath/image.png");
        Application.OpenURL("https://meijoryoga.mybluemix.net/toppage");
    }
}
