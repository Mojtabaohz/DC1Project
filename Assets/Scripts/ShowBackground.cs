using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowBackground : MonoBehaviour
{
    bool popped = false;
    public Slider bar1;
    public SpriteRenderer spriteRenderer;
 public GameObject popups;

    int limit;
    int nextlimit;
    // Start is called before the first frame update
    void Start()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        bar1 = GameObject.FindGameObjectWithTag("Slider").GetComponent<Slider>();
        switch (this.name)
        {
            case "1":limit = 0;
                nextlimit = 1000;

                break;
            case "2":limit = 1000;
                nextlimit = 2000;
                break;
            case "3": limit = 2000;
                nextlimit = 3000;
                break;
            case "4": limit = 3000;
                nextlimit = 4000;
                break;
            case "5": limit = 4000;
                nextlimit = 50000;
                break;
               
        } 
     
    }

    // Update is called once per frame
    void Update()
    {
      
        if (bar1.value >= 1000)
        {
            if (popped == false)
            {
                popups.SetActive(true);
                popped = true;
            }
        }

        else
        {
            popped = false;
            popups.SetActive(false);
        }
        if (bar1.value > limit && bar1.value < nextlimit)
        {
            this.spriteRenderer.enabled = true;

        }else
            this.spriteRenderer.enabled = false;

    }
}
