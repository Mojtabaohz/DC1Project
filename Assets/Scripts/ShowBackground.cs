using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowBackground : MonoBehaviour
{
    bool popped = false;
    public Slider bar1;
    public SpriteRenderer spriteRenderer;


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
                nextlimit = 4000;
                nextlimit = 4000;
                break;
            case "3": limit = 4000;
                nextlimit = 7000;
                break;
            case "4": limit = 7000;
                nextlimit = 10000;
                break;
            case "5": limit = 10000;
                nextlimit = 1000000;
                break;
               
        } 
     
    }

    // Update is called once per frame
    void Update()
    {
      
     
        if (bar1.value >= limit && bar1.value < nextlimit)
        {
            this.spriteRenderer.enabled = true;

        }else
            this.spriteRenderer.enabled = false;

    }
}
