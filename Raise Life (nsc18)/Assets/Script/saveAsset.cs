using UnityEngine;
using System.Collections;

public class saveAsset : MonoBehaviour {

	public void save(){
		transform.FindChild("Cow_list").GetComponent<code_Cow_list>().save();
		transform.FindChild("Ground_list").GetComponent<code_Ground_list>().save();
	}
	public void load(){
		transform.FindChild("Cow_list").GetComponent<code_Cow_list>().load();
		transform.FindChild("Ground_list").GetComponent<code_Ground_list>().load();
	}
	
}
