using UnityEngine;
using System.Collections;

public class ai : MonoBehaviour {
	public Transform rect;
	public int id = 2;
	public GameObject objToSpawn;
	// Use this for initialization
	void Start () {
		rect = gameObject.GetComponent<Transform> ();
		for (int i = 0; i < 5; i++) {
			objToSpawn = new GameObject("Cool GameObject made from Code");
			//Add Components
			objToSpawn.AddComponent<Rigidbody2D>();
			objToSpawn.AddComponent<MeshFilter>();
			objToSpawn.AddComponent<BoxCollider>();
			objToSpawn.AddComponent<MeshRenderer>();
			objToSpawn.AddComponent<SpriteRenderer>();
			objToSpawn.transform.position = new Vector2(0,0);


		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rect.Translate (0, -0.01f, 0);
		//gameObject.GetComponent<Rigidbody2D> ().AddForce (Physics.gravity * 0);
	}
}
