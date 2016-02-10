using UnityEngine;
using System.Collections;

public class tree1_s : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown (){
		GameObject.Find ("_gameAsset").transform.FindChild ("Ground_list").GetComponent<code_Ground_list> ().genground ();
		gameObject.GetComponent<SpriteRenderer> ().enabled = false;
		gameObject.GetComponent<BoxCollider2D> ().enabled = false;
		GameObject.Find ("objna").transform.FindChild ("bg").GetComponent<SpriteRenderer> ().enabled = false;
		GameObject.Find ("objna").transform.FindChild ("bg").GetComponent<BoxCollider2D> ().enabled = false;
	}
}
