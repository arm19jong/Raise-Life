using UnityEngine;
using System.Collections;

public class time : MonoBehaviour {
	private GUIStyle guiStyle = new GUIStyle(); //create a new variable
	float a=0;
	void OnGUI()
	{
		guiStyle.fontSize = 20;
		guiStyle.normal.textColor = Color.red;
		GUI.Label(new Rect(Screen.width-110, 0, 110, 50),"ฟฟฟห"+"\n"+a,  guiStyle);
	}
	void FixedUpdate()
	{
		a += Time.deltaTime;
	}
}
