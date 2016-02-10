using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class obj1 : MonoBehaviour {
	private GUIStyle guiStyle = new GUIStyle(); //create a new variable
	private Transform rect; 
	private obj1_time time;
	private SpriteRenderer pic;
	private BoxCollider2D box;
	public List<GameObject> ground_;
	public long ID=-1;

	// Use this for initialization
	void Start () {
		rect = gameObject.GetComponent<Transform> ();
		//pic = gameObject.transform.FindChild("timeleft").GetComponent<SpriteRenderer> ();

		//pic = GameObject.Find("obj").transform.FindChild("timeleft").GetComponent<SpriteRenderer> ();
		pic = GameObject.Find ("timeleft").GetComponent<SpriteRenderer> ();
		pic.enabled = false;
		box = GameObject.Find("timeleft").GetComponent<BoxCollider2D> ();
		box.enabled = false;
		//time = gameObject.transform.FindChild("timeleft").GetComponent<obj1_time> ();
		time = GameObject.Find("timeleft").GetComponent<obj1_time> ();
		//time.show = 

		//print (rect.position.x);
		gameObject.GetComponent<BoxCollider2D> ().size = gameObject.GetComponent<SpriteRenderer> ().sprite.bounds.size;
	}
	
	// Update is called once per frame
	void OnMouseDown () {
		
		if (time.timeleft <= 0) {
			//Destroy (GameObject.Find ("obj").transform.FindChild ("timeleft"));

			//GameObject.Find ("_gameAsset").transform.FindChild ("Ground_list").GetComponent<code_Ground_list> ().IDCount = ;
			ground_ = GameObject.Find ("_gameAsset").transform.FindChild ("Ground_list").GetComponent<code_Ground_list>().ground;
			GameObject.Find ("_gameAsset").transform.FindChild ("Ground_list").GetComponent<code_Ground_list>().ground.Clear();
			foreach (GameObject i in ground_) {
				if (i.transform.FindChild ("obj1").GetComponent<obj1> ().ID == ID) {				
				} else {
					GameObject.Find ("_gameAsset").transform.FindChild ("Ground_list").GetComponent<code_Ground_list> ().ground.Add (i);
				}
			}
			Destroy (GameObject.Find ("obj"));
			GameObject.Find ("objna").GetComponent<BoxCollider2D> ().enabled = true;
			GameObject.Find ("button1").GetComponent<SpriteRenderer>().enabled = true ;
		} else {
			
			GameObject.Find ("timeleft").GetComponent<SpriteRenderer> ().enabled=!GameObject.Find ("timeleft").GetComponent<SpriteRenderer> ().enabled;
			GameObject.Find ("timeleft").GetComponent<obj1_time> ().show = GameObject.Find ("timeleft").GetComponent<SpriteRenderer> ().enabled;
			GameObject.Find("timeleft").GetComponent<BoxCollider2D> ().enabled = !GameObject.Find("timeleft").GetComponent<BoxCollider2D> ().enabled;
		}
	}
	void Update () {
		
	}

}
