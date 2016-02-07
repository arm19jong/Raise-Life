using UnityEngine;
using System.Collections;

public class ccc : MonoBehaviour {
	private GUIStyle guiStyle = new GUIStyle();
	void OnGUI()
	{
		guiStyle.fontSize = 25;
		Font myFont = (Font)Resources.Load("Let's go Digital Regular", typeof(Font));
		guiStyle.font = myFont;
		//guiStyle
		guiStyle.normal.textColor = Color.green;
		string stringna = @"
123456789
A123456789";

		GUI.Label(new Rect(Screen.width-210, (Screen.height/2)-30, 110, 50),stringna, guiStyle);

		//GUI.Label(new Rect(Screen.width-210, (Screen.height/2)-30, 110, 50),aaa);
	}
}
