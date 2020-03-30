using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class toGoals : MonoBehaviour
{
    // Start is called before the first frame update
    public void Clicked()
    {
       
        SceneManager.LoadScene("goals");
    }
}
