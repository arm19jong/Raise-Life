using UnityEngine;
using System.Collections;
//using UnityEngine.Time;

public class obj1_time : MonoBehaviour {
	private GUIStyle guiStyle = new GUIStyle(); //create a new variable
	public float timeleft;
	public bool show;
	// Use this for initialization
	void Start () {
		timeleft = 5.0f;
		show = false;
	}
	
	// Update is called once per frame
	void Update () {
		timeleft -= Time.deltaTime;
		if (Mathf.RoundToInt (timeleft) <= 0) {
			timeleft = 0;
			//gameObject.GetComponent<SpriteRenderer> ().sprite = Resources.Load("img1", typeof(Sprite)) as Sprite;
			GameObject.Find("obj").transform.FindChild("obj1").GetComponent<SpriteRenderer>().sprite = Resources.Load("img1", typeof(Sprite)) as Sprite;
			//transform.localScale = new Vector3 (0.3f, 0.3f, 1f);
			GameObject.Find("obj").transform.FindChild("obj1").GetComponent<Transform>().transform.localScale=new Vector3 (0.2f, 0.2f, 1f);
			GameObject.Find("obj").transform.FindChild("obj1").GetComponent<BoxCollider2D> ().size = new Vector2 (5f, 4.2f);
		}


	}
	void OnGUI()
	{
		guiStyle.fontSize = 25;
		Font myFont = (Font)Resources.Load("Let's go Digital Regular", typeof(Font));
		guiStyle.font = myFont;
		//guiStyle
		guiStyle.normal.textColor = Color.black;
		if (show == true) {
			GUI.Label (new Rect (Screen.width / 2, Screen.height / 2, 110, 50), (Mathf.RoundToInt (timeleft)).ToString (), guiStyle);
		} else
			{
			GUI.Label (new Rect (Screen.width / 2, Screen.height / 2, 110, 50), "", guiStyle);
			}
	}
	void OnMouseDown () {
		show = !show;
		gameObject.GetComponent<SpriteRenderer> ().enabled = false;
		gameObject.GetComponent<BoxCollider2D> ().enabled = false;
		//pic.enabled=!pic.enabled;
	}
}
