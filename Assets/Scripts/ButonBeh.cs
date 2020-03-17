using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ButonBeh : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
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
    int allMachnines = 12;
    GameObject Manage;
    public int Id;
    int count = 0;
    int hold = 0;
    bool inside = false;
    string  CurTime;
    string CurTime1;
    string CurTime2;
    string CurTime3;
    int timeSpend;
    string isAM;
    int placeholder;
    // Start is called before the first frame update



    void OnDestroy()
    {
        PlayerPrefs.SetInt("PrevTime", int.Parse(CurTime) + placeholder * 3600 + int.Parse(CurTime2)*60);
        Debug.Log("PlayerPrefs.GetInt()");
        PlayerPrefs.SetInt("Cur3P", int.Parse(CurTime3));
        PlayerPrefs.SetFloat("Slid", bar.value);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            GameObject.FindGameObjectWithTag("Manager").GetComponent<GameManager>().selectedID = Id;
            PlayerPrefs.SetInt("RemId", Id);
        }



    }
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        inside = true;
    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        inside = false;
    }



    // Update is called once per frame
    void Start()
    {
        CurTime = System.DateTime.Now.ToString("ss");
        CurTime1 = System.DateTime.Now.ToString("hh");
        CurTime2 = System.DateTime.Now.ToString("mm");
        CurTime3 = System.DateTime.Now.ToString("dd");
        isAM= System.DateTime.Now.ToString("tt");
        
        Debug.Log(CurTime);
       
        Debug.Log(CurTime2);
        int.Parse(CurTime3);
        //  Debug.Log(int.Parse(CurTime) + int.Parse(CurTime1) + int.Parse(CurTime2));
        int.Parse(CurTime);
        int.Parse(CurTime1);
        int.Parse(CurTime2);
        if (isAM == "pm")
        {
            placeholder = int.Parse(CurTime1);
           placeholder += 12;

        }
        Debug.Log(placeholder);

        timeSpend = (int.Parse(CurTime) + placeholder *3600 + int.Parse(CurTime2) *60)-PlayerPrefs.GetInt("PrevTime", 0) + ((int.Parse(CurTime3) -PlayerPrefs.GetInt("Cur3P", 0)) * 86400);


        Debug.Log(timeSpend);
        if (SceneManager.GetActiveScene().name == "DeviceSettings") 
        {
            bar=GameObject.FindGameObjectWithTag("Slider").GetComponent<Slider>();
            bar.value = PlayerPrefs.GetFloat("Slid", 0);
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
            bar.value = PlayerPrefs.GetFloat("Slid", 0);

            active = new int[allMachnines];

            while (count < allMachnines)
            {

                act = PlayerPrefs.GetInt("act" + Id, -1);



                if (act == 1)
                {
                    But1.GetComponent<Image>().color = new Color(0, 50, 200);
                    active[count] = count;

                    activated = true;

                    arrayP = 1;




                }
                else
                { arrayP = 0; }
                count++;
            }
        }



    }
    void LateUpdate()
    {

        TimeInterval += Time.deltaTime;
        if (TimeInterval >= 1)
        {
            if (activated)
            {

                bar.value += average/60.0f;
              
            }
            if (inside)
            {
                if (isPressed)
                {
                    counter++;
                    if (counter > 1.5)
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
                            PlayerPrefs.SetFloat("Slid", bar.value);
                            SceneManager.LoadScene("DeviceSettings");


                    }
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
            But1.GetComponent<Image>().color = new Color(0, 50, 200);
            arrayP = 1;
            activated = true;
            PlayerPrefs.SetInt("act" + Id, 1);
        }




        if (SceneManager.GetActiveScene().name == "DeviceSettings")
        {

        }
    }

}

