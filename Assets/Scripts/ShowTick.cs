using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowTick : MonoBehaviour
{
    bool passed;
    public int IdDay;

    // Start is called before the first frame update
    void Start()
    {


        for (int i = 0; i < 30; i++)
        {
            if ((PlayerPrefs.GetInt("possitive" + i, 0)) == 1)
            {
                gameObject.SetActive(true);
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
    void show()
    {

        gameObject.SetActive(true);
        PlayerPrefs.SetInt("possitive" + IdDay, 1);
    }
}
