﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Back : MonoBehaviour
{

    public void Clicked()
    {
       
        SceneManager.LoadScene("SampleScene");
    }
}
