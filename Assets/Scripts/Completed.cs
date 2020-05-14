using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Completed : MonoBehaviour
{
    public int goalNumber;
    public GameObject No;
    public GameObject Yes;
    // Start is called before the first frame update
    void Start()
    {
      
            if (PlayerPrefs.GetInt("Number1", 0) == 1 && PlayerPrefs.GetInt("Number2", 0) == 1 && PlayerPrefs.GetInt("Number3", 1) == 0)
            {
                PlayerPrefs.SetInt("Number4", 1);

            }
            else
            {
                PlayerPrefs.SetInt("Number4", 0);
            }
        
        if (PlayerPrefs.GetInt("Number" + goalNumber, 0     ) == 0)
        {
            No.SetActive(true);
            Yes.SetActive(false);
        }
        else
        {
            Yes.SetActive(true);
            No.SetActive(false);
        }
       
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
