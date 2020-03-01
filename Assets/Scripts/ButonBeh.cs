using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ButonBeh : MonoBehaviour, IPointerDownHandler
{
    public Button But1;
    public bool activated;
    public Slider bar;
    bool isPressed = false;
    int counter;
    float TimeInterval;
    public int average;
    int IDs;
    int PPref;
    int arrayP;
    int act;
    int[] active;
    int allMachnines=12;
    GameObject Manage;
    public int Id;
    int count = 0;
    int hold = 0;
    // Start is called before the first frame update

        

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            GameObject.FindGameObjectWithTag("Manager").GetComponent<GameManager>().selectedID = Id;
            PlayerPrefs.SetInt("RemId", Id);
        }
        
        

    }




    // Update is called once per frame
    void Start()
    {

        if (SceneManager.GetActiveScene().name == "DeviceSettings")
        {

            arrayP = PlayerPrefs.GetInt("ifactivated", 0);
            if (arrayP == 1)
            {
                activated = true;
                But1.GetComponent<Image>().color = new Color(0, 50, 200);
                
            }
            else
            {

                activated = false;
            }
        }
        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            //act = PlayerPrefs.GetInt("act" + active[count], 0);
           
            active = new int[allMachnines];
        
            while ( count < allMachnines){

                act = PlayerPrefs.GetInt("act" + Id, -1);

               

                if (act == 1)
                {
                        But1.GetComponent<Image>().color = new Color(0, 50, 200);
                        active[count] = count;

                        activated = true;
                    
                        arrayP = 1;
                       



                    }else
                { arrayP = 0; }
                count++;
            }
        }



    }
void LateUpdate()
    {
        
        TimeInterval += Time.deltaTime;
        if (TimeInterval > 1)
        {
            if (activated)
            {
                
                bar.value += average;
            }
        if (isPressed)
        {
            counter++;
            if (counter >=1)
            {

                    if (activated)
                    {
                        PPref = 1;

                    }
                    else
                    {
                        PPref = 0;

                    }
                    
                   PlayerPrefs.SetInt("ifactivated", arrayP);
                    if (SceneManager.GetActiveScene().name == "SampleScene")
                        SceneManager.LoadScene("DeviceSettings");
                   

                }
        }
            TimeInterval = 0;
          
        }
    }
    public void Clicked()
    {
        isPressed = false;
        TimeInterval = 0;
      

        if (activated)
        {
            But1.GetComponent<Image>().color = Color.white;
            arrayP = 0;
            activated = false;
            PlayerPrefs.SetInt("act" + Id, 0);
        }
        else
        {
            But1.GetComponent<Image>().color = new Color(0,50,200);
            arrayP = 1;
            activated = true;
            PlayerPrefs.SetInt("act" + Id, 1);
        }
    

       
     
        if (SceneManager.GetActiveScene().name == "DeviceSettings")
        {

        }
    }

}

