using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowX : MonoBehaviour
{
    bool passed;
    public int IdDay;
    int count=0;
    int holder;
    string Day;
    // Start is called before the first frame update
    void Start()
    {


        show();


        

    }
    void show()
    {
        
        holder = PlayerPrefs.GetInt("negative" + IdDay, 0);
      
        if (holder == 1)
        {


            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
      
    }
}
