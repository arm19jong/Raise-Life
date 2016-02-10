using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class code_Ground_list : MonoBehaviour {
	public List<GameObject> ground;
	public long IDCount;
	void Awake(){
		ground = new List<GameObject> ();
		IDCount = 0;
	}
	public void genground(){
		
		GameObject clone = Instantiate(Resources.Load("obj"), Vector3.zero, Quaternion.identity) as GameObject;
		clone.transform.SetParent(GameObject.Find("_gameAsset").transform.FindChild("Ground_list").GetComponent<Transform>());
		clone.name = "obj";
		clone.transform.position = new Vector3(-0.4f, 1.21f, 0);
		//print (clone.transform.FindChild ("obj1").GetComponent<obj1> ().ID);
		clone.transform.FindChild("obj1").GetComponent<obj1> ().ID=IDCount;
		ground.Add (clone);
		IDCount++;


	}
	public void save(){
		
		SaveClass.s.sground.Clear ();
		foreach(GameObject i in ground){
			SaveClass.s.sground.Add(new save_Ground(i.transform.FindChild ("obj1").GetComponent<obj1> ().ID, i.transform.FindChild ("obj1").GetComponent<Transform>().position.x, i.transform.FindChild ("obj1").GetComponent<Transform>().position.y, i.transform.FindChild("timeleft").GetComponent<obj1_time>().timeleft));
		}
		print ("all ground save");
		SaveClass.s.IDCount_g = IDCount;
	}

	public void load(){
		foreach (GameObject i in ground) {
			Destroy(i);
		}
		ground.Clear ();
		foreach (save_Ground i in SaveClass.s.sground) {
			GameObject a = Instantiate(Resources.Load("obj"), new Vector2(0, 0), Quaternion.Euler(0,0,0)) as GameObject;
			a.transform.SetParent(GameObject.Find("_gameAsset").transform.FindChild("Ground_list").GetComponent<Transform>());
			a.name = "obj";
			a.transform.position = new Vector3(-0.4f, 1.21f, 0);
			//a.GetComponent<>().ID = i.ID;
			a.transform.FindChild("obj1").GetComponent<obj1> ().ID=i.ID;
			a.transform.FindChild ("timeleft").GetComponent<obj1_time> ().timeleft = i.timeleft;
			a.transform.FindChild ("timeleft").GetComponent<SpriteRenderer> ().enabled = false;
			//GameObject.Find ("button1").GetComponent<SpriteRenderer> ().enabled = false;
			//GameObject.Find ("button1").GetComponent<BoxCollider2D> ().enabled = false;

			ground.Add(a);
		}
		IDCount = SaveClass.s.IDCount_g;
		GameObject.Find ("button1").GetComponent<SpriteRenderer> ().enabled = false;
		//GameObject.Find ("button1").GetComponent<BoxCollider2D> ().enabled = false;
	}

}
