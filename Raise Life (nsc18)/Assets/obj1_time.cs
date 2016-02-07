using UnityEngine;
using System.Collections;
//using UnityEngine.Time;

public class obj1_time : MonoBehaviour {
	private GUIStyle guiStyle = new GUIStyle(); //create a new variable
	private float timeleft;
	public bool show;
	// Use this for initialization
	void Start () {
		timeleft = 10.0f;
		show = false;
	}
	
	// Update is called once per frame
	void Update () {
		timeleft -= Time.deltaTime;
	}
	void OnGUI()
	{
		guiStyle.fontSize = 25;
		Font myFont = (Font)Resources.Load("Let's go Digital Regular", typeof(Font));
		guiStyle.font = myFont;
		//guiStyle
		guiStyle.normal.textColor = Color.black;
		if (show == true) {
			GUI.Label (new Rect (Screen.width / 2, Screen.height / 2, 110, 50), (Mathf.CeilToInt (timeleft)).ToString (), guiStyle);
		} else
			{
			GUI.Label (new Rect (Screen.width / 2, Screen.height / 2, 110, 50), "", guiStyle);
			}
	}
	void OnMouseDown () {
		show = !show;
		gameObject.GetComponent<SpriteRenderer> ().enabled=false;
		//pic.enabled=!pic.enabled;
	}
}
