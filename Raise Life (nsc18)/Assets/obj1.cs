using UnityEngine;
using System.Collections;

public class obj1 : MonoBehaviour {
	private GUIStyle guiStyle = new GUIStyle(); //create a new variable
	private Transform rect; 
	private obj1_time time;
	private SpriteRenderer pic;
	private BoxCollider2D box;
	public long ID=-1;

	// Use this for initialization
	void Start () {
		rect = gameObject.GetComponent<Transform> ();
		//pic = gameObject.transform.FindChild("timeleft").GetComponent<SpriteRenderer> ();

		pic = GameObject.Find("obj").transform.FindChild("timeleft").GetComponent<SpriteRenderer> ();
		pic.enabled = false;
		box = GameObject.Find("obj").transform.FindChild("timeleft").GetComponent<BoxCollider2D> ();
		box.enabled = false;
		//time = gameObject.transform.FindChild("timeleft").GetComponent<obj1_time> ();
		time = GameObject.Find("obj").transform.FindChild("timeleft").GetComponent<obj1_time> ();
		//print (rect.position.x);
		gameObject.GetComponent<BoxCollider2D> ().size = gameObject.GetComponent<SpriteRenderer> ().sprite.bounds.size;
	}
	
	// Update is called once per frame
	void OnMouseDown () {
		
		if (time.timeleft <= 0) {
			//Destroy (GameObject.Find ("obj").transform.FindChild ("timeleft"));
			Destroy (GameObject.Find ("obj"));
		} else {
			time.show = !time.show;
			pic.enabled=!pic.enabled;
			box.enabled = !box.enabled;
		}
	}
	void Update () {
		
	}

}
