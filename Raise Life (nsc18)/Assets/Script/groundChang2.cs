using UnityEngine;
using System.Collections;

public class groundChang2 : MonoBehaviour {

	// Use this for initialization
	//public ima
	public vvv2 code2;
	public warp cc;
	public int num2;
	void Start () {
		//code = GameObject.Find ("ground_set(Clone)").GetComponent<vvv> ();
		//cc = GameObject.Find ("warp").GetComponent<warp> ();
		num2 = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void clickdown(){
		GameObject clone = Instantiate(Resources.Load("ground_set2"), Vector3.zero, Quaternion.identity) as GameObject;
		clone.name = "bbb"+num2;
		//clone.transform.SetParent(GameObject.Find("_gameAsset").transform.FindChild("Cow_list").GetComponent<Transform>());
		clone.transform.position = new Vector3(-55, 0, 0);
		num2 += 1;

	}
	public void clickup(){
		code2 = GameObject.Find ("bbb"+(num2-1)).GetComponent<vvv2> ();
		code2.enabled = false;
		//(GetComponent ("warp") as MonoBehaviour).enabled = false;
		//code.enabled = false;

		//cc.enabled = false;

	}
}
