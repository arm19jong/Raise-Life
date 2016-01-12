using UnityEngine;
using System.Collections;

public class groundChang : MonoBehaviour {

	// Use this for initialization
	//public ima
	public vvv code;
	public warp cc;
	public int num;
	void Start () {
		//code = GameObject.Find ("ground_set(Clone)").GetComponent<vvv> ();
		//cc = GameObject.Find ("warp").GetComponent<warp> ();
		num = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void clickdown(){
		GameObject clone = Instantiate(Resources.Load("ground_set"), Vector3.zero, Quaternion.identity) as GameObject;
		clone.name = "aaa"+num;
		//clone.transform.SetParent(GameObject.Find("_gameAsset").transform.FindChild("Cow_list").GetComponent<Transform>());
		clone.transform.position = new Vector3(-55, 0, 0);
		num += 1;

	}
	public void clickup(){
		code = GameObject.Find ("aaa"+(num-1)).GetComponent<vvv> ();
		code.enabled = false;
		//(GetComponent ("warp") as MonoBehaviour).enabled = false;
		//code.enabled = false;

		//cc.enabled = false;

	}
}
