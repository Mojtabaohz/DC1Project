using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class GameManager : MonoBehaviour
{
    public int selectedID;
    public int ifActivated;
    public GameObject prefabs;




    void Start()
    { 
    // Start is called before the first frame update
    if (SceneManager.GetActiveScene().name == "DeviceSettings")
        {
            selectedID = PlayerPrefs.GetInt("RemId", 0);
        
            prefabs = Instantiate(Resources.Load<GameObject>("Prefabs/" + selectedID));
        
            //prefabs = Instantiate(Resources.Load<GameObject>("Prefabs/personalMachine(original)"));
        
            prefabs.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);

        
            
        }
    }

    // Update is called once per frame
    void Update()
{

}
}
