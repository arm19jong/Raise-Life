using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class code_Cow_list : MonoBehaviour {
	public List<GameObject> cow;
	public long IDCount;
	void Awake(){
		cow = new List<GameObject> ();
		IDCount = 0;
	}
	public void gencow(){
		GameObject clone = Instantiate(Resources.Load("cow1"), Vector3.zero, Quaternion.identity) as GameObject;
		clone.transform.SetParent(GameObject.Find("_gameAsset").transform.FindChild("Cow_list").GetComponent<Transform>());
		clone.transform.position = new Vector3(5, 2, 0);
		clone.GetComponent<cow> ().ID=IDCount;
		cow.Add (clone);
		IDCount++;
	}
	public void save(){
		SaveClass.s.scow.Clear ();
		foreach(GameObject i in cow){
			SaveClass.s.scow.Add(new save_Cow(i.GetComponent<cow>().ID, i.GetComponent<Transform>().position.x, i.GetComponent<Transform>().position.y));
		}
		print ("all cow save");
		SaveClass.s.IDCount = IDCount;
	}
	public void load(){
		foreach (GameObject i in cow) {
			Destroy(i);
		}
		cow.Clear ();


		foreach (save_Cow i in SaveClass.s.scow) {
			GameObject a = Instantiate(Resources.Load("cow1"), new Vector2(i.x, i.y), Quaternion.Euler(0,0,0)) as GameObject;
			a.transform.SetParent(GameObject.Find("_gameAsset").transform.FindChild("Cow_list").GetComponent<Transform>());
			a.GetComponent<cow>().ID = i.ID;
			cow.Add(a);
		}
		IDCount = SaveClass.s.IDCount;
	}


}
