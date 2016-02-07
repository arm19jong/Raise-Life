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
		GameObject clone = Instantiate(Resources.Load("obj"), Vector3.zero, Quaternion.identity) as GameObject;
		//clone.transform.SetParent(GameObject.Find("_gameAsset").transform.FindChild("Cow_list").GetComponent<Transform>());
		clone.name = "obj";
		clone.transform.position = new Vector3(-0.4f, 1.21f, 0);
		gameObject.GetComponent<SpriteRenderer> ().enabled = false;
		gameObject.GetComponent<BoxCollider2D> ().enabled = false;
		GameObject.Find ("objna").transform.FindChild ("bg").GetComponent<SpriteRenderer> ().enabled = false;
	}
}
