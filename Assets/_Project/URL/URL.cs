﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class URL : MonoBehaviour
{
   public void onClick()
    {
        Application.OpenURL("https://meijoryoga.mybluemix.net/toppage");//""の中には開きたいWebページのURLを入力します
    }
}