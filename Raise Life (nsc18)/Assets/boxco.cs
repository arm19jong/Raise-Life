using UnityEngine;
using System.Collections;

public class boxco : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown (){
		gameObject.GetComponent<SpriteRenderer> ().enabled = false;
		gameObject.GetComponent<BoxCollider2D> ().enabled = false;
		GameObject.Find("objna").transform.FindChild("tree1").GetComponent<SpriteRenderer> ().enabled = false;
		GameObject.Find("objna").transform.FindChild("tree1").GetComponent<BoxCollider2D> ().enabled = false;
		GameObject.Find ("button1").GetComponent<SpriteRenderer> ().enabled = true;
		GameObject.Find ("objna").GetComponent<BoxCollider2D> ().enabled =true;
	}
}
