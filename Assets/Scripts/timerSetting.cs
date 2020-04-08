using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class timerSetting : MonoBehaviour
{
    // Start is called before the first frame update
    public Button incButton;
	public Button decButton;
	public Button incAvg;
	public Button decAvg;
	public Button appAvg;
	public Button applyButton;
	public Text TimeValue;
	public Text avgText;
	public Slider bar;
	public float minInterval = 10;
	public int minAvg = 10;
	public int average;
	public float usageTime ;
    public int Id;
    public GameObject stat;
	void Start () {
        Id = PlayerPrefs.GetInt("RemId", 50);
        Button inc_btn = incButton.GetComponent<Button>();
		Button dec_btn = decButton.GetComponent<Button>();
		Button app_btn = applyButton.GetComponent<Button>();
		inc_btn.onClick.AddListener(IncTimer);
		dec_btn.onClick.AddListener(DecTimer);
		app_btn.onClick.AddListener(AppTimer);

		Button inc_avg = incAvg.GetComponent<Button>();
		Button dec_avg = decAvg.GetComponent<Button>();
		Button app_avg = appAvg.GetComponent<Button>();
		inc_avg.onClick.AddListener(IncAvg);
		dec_avg.onClick.AddListener(DecAvg);
		app_avg.onClick.AddListener(AppAvg);

		Text txt = TimeValue.GetComponent<Text>();
		usageTime = int.Parse(txt.text);

		bar=GameObject.FindGameObjectWithTag("Slider").GetComponent<Slider>();

		
		average = PlayerPrefs.GetInt("Average", 50);
		Text avg_txt = avgText.GetComponent<Text>();
		avg_txt.text = average.ToString();
		//avg_txt = average.ToString();
	}

	void IncTimer(){
		//Debug.Log ("You have clicked the Inc button!");
		Text txt = TimeValue.GetComponent<Text>();
		usageTime = int.Parse(txt.text) + minInterval;
		txt.text = usageTime.ToString();

	}
	void DecTimer(){
		//Debug.Log ("You have clicked the Dec button!");
		Text txt = TimeValue.GetComponent<Text>();
		usageTime = int.Parse(txt.text) - minInterval;
		txt.text = usageTime.ToString();
	}
	void AppTimer(){
		Debug.Log ("You have clicked the app button!");
        bar.value = PlayerPrefs.GetFloat("Slid", 0);
		bar.value += (average/60.0f)*usageTime;
		PlayerPrefs.SetFloat("Slid", bar.value);
	}
	
	void IncAvg(){
		Text avg_txt = avgText.GetComponent<Text>();
		average = int.Parse(avg_txt.text) + minAvg;
		avg_txt.text = average.ToString();
        Debug.Log("You have clicked the apply avg button!");
    }
	void DecAvg(){
		Text avg_txt = avgText.GetComponent<Text>();
		average = int.Parse(avg_txt.text) - minAvg;
		avg_txt.text = average.ToString();
	}
	public void AppAvg(){
        Text avg_txt = avgText.GetComponent<Text>();
        average = int.Parse(avg_txt.text);
        
        PlayerPrefs.SetInt("Average" + Id, average);
       
        Debug.Log("that" + average);

        PlayerPrefs.SetInt("Average", average);
	}

}
