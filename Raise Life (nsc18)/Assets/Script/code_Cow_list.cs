using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class code_Cow_list : MonoBehaviour {
	public List<GameObject> cow;
	void Awake(){
		cow = new List<GameObject> ();
	}
	public void gencow(){
		GameObject clone = Instantiate(Resources.Load("cow1"), Vector3.zero, Quaternion.identity) as GameObject;
		clone.transform.SetParent(GameObject.Find("_gameAsset").transform.FindChild("Cow_list").GetComponent<Transform>());
		clone.transform.position = new Vector3(5, 2, 0);
		cow.Add (clone);
	}


}
