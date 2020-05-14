using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowTick : MonoBehaviour
{
    bool passed;
    public int IdDay;
    int count = 0;
    int holder;
    string Day;
    public int tester;
    // Start is called before the first frame update
    void Start()
    {


        show();




    }
    void show()
    {
        tester= PlayerPrefs.GetInt("tester", 0);
        holder = PlayerPrefs.GetInt("possitive" + IdDay, 0);

        if (holder == 1)
        {

            tester++;
            Debug.Log(tester);
            PlayerPrefs.SetInt("tester", tester);
            if (tester == 30)
            {
                PlayerPrefs.SetInt("Number2", 1);
            }
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
        if(PlayerPrefs.GetInt("possitive30", 0) == 1)
        {
            PlayerPrefs.SetInt("possitive" + IdDay, 0);

        }
    }
    void OnDestroy()
    {
        PlayerPrefs.SetInt("tester", 0);
    }
}
