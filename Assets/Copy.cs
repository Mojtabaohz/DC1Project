using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Copy : MonoBehaviour
{
    public Slider slider;
    public Text text;
    public string text1;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        

    
        text1 = slider.value.ToString("#");
        text.text= text1+"kw";
    }
}
