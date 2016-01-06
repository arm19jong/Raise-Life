using UnityEngine;
using System.Collections;
//using UnityEditor;
//using UnityEditor;

using UnityStandardAssets.CrossPlatformInput;
public class prefab : MonoBehaviour {
	//public prefab b;
	public bool isclick = false;
	//public NewBehavi classAObj;
	//public Transform cow;
	// Use this for initialization
	//@MenuItem("AssetDatabase/LoadAssetExample");
	void Start () {
		/*
		for(int i = 1;i<=2;i++)
		{
			Object prefab = AssetDatabase.LoadAssetAtPath("Assets/prefab/cow.prefab", typeof(GameObject));
			GameObject clone = Instantiate(prefab, Vector3.zero, Quaternion.identity) as GameObject;
			clone.transform.position = new Vector3(0, i, 0);
	
		}
		*/

		//b = GameObject.Find ("MobileSingleStickControl").transform.FindChild ("JumpButton").GetComponent<conver> ();
	}
	
	// Update is called once per frame
	void Update () {
		//isclick = CrossPlatformInputManager.GetButton ("Jump");

		//print (isclick);
		//print ("a");
		if (Input.GetKey (KeyCode.Space)) {
			buttonBoot_Down();
		}

	}
	public void buttonBoot_Down(){
		//GameObject clone = Instantiate(Resources.Load("cow1"), Vector3.zero, Quaternion.identity) as GameObject;
		//clone.transform.SetParent(GameObject.Find("_gameAsset").transform.FindChild("Cow_list").GetComponent<Transform>());
		//clone.transform.position = new Vector3(5, 2, 0);
		isclick = true;

	}
	public void buttonBoot_Up(){

		isclick = false;
		
	}

		
	/*
	public void OnGUI() {
		//isclick = CrossPlatformInputManager.GetButton ("Jump");
		if (isclick) {
			GUI.Label(new Rect(10, 10, 100, 20), "Hello World!");
		}
	}
	*/
}
