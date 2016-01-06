using UnityEngine;
using System.Collections;
using System.Collections.Generic;
[System.Serializable]
public class SaveClass {
	public static SaveClass s = new SaveClass();
	public SaveClass(){}
	public save_Player Splayer = new save_Player();
	public long IDCount = 0;
	public List<save_Cow> scow = new List<save_Cow> ();


}
