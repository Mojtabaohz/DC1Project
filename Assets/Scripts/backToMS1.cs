using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class backToMS1 : MonoBehaviour
{
    public Slider bar;

    void Start()
    {
       
    }
    public void Clicked()
    {
     
        SceneManager.LoadScene("Achievements");
    }
}

