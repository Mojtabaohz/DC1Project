using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class backToMS : MonoBehaviour
{
    public Slider bar;

    void Start()
    {
       
    }
    public void Clicked()
    {
        PlayerPrefs.SetFloat("Slid", bar.value);
        SceneManager.LoadScene("SampleScene");
    }
}

