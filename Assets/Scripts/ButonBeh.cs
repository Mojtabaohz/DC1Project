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
    float timeToday;
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
    int today;
    int daycounter=1;
    public GameObject fridge;
    // Start is called before the first frame update
    public int daysInARow;


    void OnDestroy()
    {
        CurTime = System.DateTime.Now.ToString("ss");
        CurTime1 = System.DateTime.Now.ToString("hh");
        CurTime2 = System.DateTime.Now.ToString("mm");
        CurTime3 = System.DateTime.Now.ToString("dd");
        
        PlayerPrefs.SetInt("PrevTime", int.Parse(CurTime) + placeholder * 3600 + int.Parse(CurTime2)*60);
      // Debug.Log("ssb"+int.Parse(CurTime));
      // Debug.Log("hhb"+placeholder);
       // Debug.Log("mmb"+int.Parse(CurTime2));
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
    void Update()
    {
       
    }
  
    void Start()
    {
        PlayerPrefs.SetInt("Number2", 0);

        if (SceneManager.GetActiveScene().name == "DeviceSettings")
        {

            Id = PlayerPrefs.GetInt("RemId", 50);
          
        }
        daysInARow = PlayerPrefs.GetInt("Days", 0);
        average = PlayerPrefs.GetInt("Average" + Id, 80);

        CurTime = System.DateTime.Now.ToString("ss");
        CurTime1 = System.DateTime.Now.ToString("hh");
        CurTime2 = System.DateTime.Now.ToString("mm");
        CurTime3 = System.DateTime.Now.ToString("dd");
        isAM= System.DateTime.Now.ToString("tt");
        
      //  
       
    //    Debug.Log(CurTime2);
        int.Parse(CurTime3);
        //  Debug.Log(int.Parse(CurTime) + int.Parse(CurTime1) + int.Parse(CurTime2));
        int.Parse(CurTime);
        int.Parse(CurTime1);
        int.Parse(CurTime2);
        placeholder = int.Parse(CurTime1);
        if (isAM == "pm")
        {
            
           placeholder += 12;

        }
        //Debug.Log(placeholder);
        
        timeSpend = (int.Parse(CurTime) + placeholder *3600 + int.Parse(CurTime2) *60)-PlayerPrefs.GetInt("PrevTime", 0);
        today = int.Parse(CurTime3) - PlayerPrefs.GetInt("Cur3P", 0);
        
        if (today > 1)
        {
            timeSpend += (int.Parse(CurTime3) - PlayerPrefs.GetInt("Cur3P", 0)-1) * 86400;
            PlayerPrefs.SetInt("Days", 0);
        }

        if (today == 1) {
            
              
          
           

            if (gameObject.name == "FridgeB")
            {
                daysInARow++;
                PlayerPrefs.SetInt("Days", daysInARow);
                timeToday = timeSpend - (int.Parse(CurTime) + placeholder * 3600 + int.Parse(CurTime2) * 60);
                if (daysInARow == 7)
                {
                    PlayerPrefs.SetInt("Number3", 1);
                    PlayerPrefs.SetInt("Days", 0);
                }
                if (bar.value <= 5000)
                {

                    PlayerPrefs.SetInt("Number1", 1);
                }

                if (bar.value >= 10000)
                {
                    daycounter = PlayerPrefs.GetInt("daycounter", 1);
                    PlayerPrefs.SetInt("negative" + daycounter, 1);
                    daycounter++;

                    if (daycounter >= 31)
                    {
                        daycounter = 1;
                        for (int i = 0; i <= 30; i++)
                        {
                            PlayerPrefs.SetInt("possitive" + i, 0);
                            PlayerPrefs.SetInt("negative" + i, 0);

                        }
                    }
                    PlayerPrefs.SetInt("daycounter", daycounter);
                    Debug.Log("hi");
                }
                else
                {
                    daycounter = PlayerPrefs.GetInt("daycounter", 1);
                    PlayerPrefs.SetInt("possitive" + daycounter, 1);
                    daycounter++;

                    if (daycounter >= 31)
                    {
                        daycounter = 1;
                        for (int i = 0; i <= 30; i++)
                        {
                            PlayerPrefs.SetInt("possitive" + i, 0);
                            PlayerPrefs.SetInt("negative" + i, 0);

                        }
                    }
                    PlayerPrefs.SetInt("daycounter", daycounter);
                    Debug.Log(daycounter);
                }
            }
        }
      //  Debug.Log("nowhh" + placeholder);
      //  Debug.Log("nowmm" + int.Parse(CurTime2));
       // Debug.Log("nowss" + int.Parse(CurTime));
       // Debug.Log("Beftime" + PlayerPrefs.GetInt("PrevTime", 0));
       //Debug.Log("timespend"+timeSpend);
        if (SceneManager.GetActiveScene().name == "DeviceSettings") 
        {
            bar=GameObject.FindGameObjectWithTag("Slider").GetComponent<Slider>();
            bar.value = PlayerPrefs.GetFloat("Slid", 0);
            arrayP = PlayerPrefs.GetInt("ifactivated", 0);

            if (arrayP == 1)
            {
                activated = true;
                But1.GetComponent<Image>().color = new Color(0, 50, 0, 0.2f);
                Debug.Log("hi");
            }
            else
            {
                But1.GetComponent<Image>().color = new Color(0, 50, 200, 0.2f);
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
                    But1.GetComponent<Image>().color = new Color(0, 0, 200,0.2f);
                    active[count] = count;

                    activated = true;

                    arrayP = 1;
                    //not tested VVV
                    bar.value += timeSpend * 60;



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
                        {
                            PlayerPrefs.SetInt("Average", average);
                            PlayerPrefs.SetFloat("Slid", bar.value);
                            SceneManager.LoadScene("DeviceSettings");
                        }

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
            But1.GetComponent<Image>().color = new Color(256, 256, 256, 0.2f);
            arrayP = 0;
            activated = false;
            PlayerPrefs.SetInt("act" + Id, 0);
        }
        else
        {
            But1.GetComponent<Image>().color = new Color(0, 0, 200, 0.2f);
            arrayP = 1;
            activated = true;
            PlayerPrefs.SetInt("act" + Id, 1);
        }




        
    }

}

