using UnityEngine;
using System.Collections;

public class obj1 : MonoBehaviour {
	private GUIStyle guiStyle = new GUIStyle(); //create a new variable
	private Transform rect; 
	private obj1_time time;
	private SpriteRenderer pic;

	// Use this for initialization
	void Start () {
		rect = gameObject.GetComponent<Transform> ();
		pic = gameObject.transform.FindChild("timeleft").GetComponent<SpriteRenderer> ();
		pic.enabled = false;
		time = gameObject.transform.FindChild("timeleft").GetComponent<obj1_time> ();
		print (rect.position.x);
	}
	
	// Update is called once per frame
	void OnMouseDown () {
		time.show = !time.show;
		pic.enabled=!pic.enabled;
	}
	void Update () {
		
	}

}
