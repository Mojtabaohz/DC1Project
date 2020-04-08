using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class toGoals : MonoBehaviour
{
    int daycounter;
    // Start is called before the first frame update
    public void Clicked()
    {
       
        go();    }
    void go() {
        SceneManager.LoadScene("goals");
    }
}
