using UnityEngine;
using System.Collections;

public class time : MonoBehaviour {
	private GUIStyle guiStyle = new GUIStyle(); //create a new variable
	float a=0;
	int min = 0;
	public int hours = 6;
	string s_min = "";
	string s_hours = "";
	void OnGUI()
	{
		guiStyle.fontSize = 25;
		Font myFont = (Font)Resources.Load("Let's go Digital Regular", typeof(Font));
		guiStyle.font = myFont;
		//guiStyle
		guiStyle.normal.textColor = Color.black;
		s_min = min.ToString("00");
		s_hours = hours.ToString ("00");
		GUI.Label(new Rect(Screen.width-110, 5, 110, 50),"AaBbCc"+"\n"+s_hours+":"+s_min,  guiStyle);
	}
	void FixedUpdate()
	{
		a += Time.deltaTime;
		if (a>=10){
			a=0;
			min+=10;
		}
		if (min>=60){
			min=0;
			hours+=1;
		}
		if(hours>=24){
			hours=0;
		}
	}
}
