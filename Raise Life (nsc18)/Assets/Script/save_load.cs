using UnityEngine;
using System.Collections;
using System.Collections.Generic; 
using System.Runtime.Serialization.Formatters.Binary; 
using System.IO;

public class save_load : MonoBehaviour {
	public static List<SaveClass> savedGames = new List<SaveClass>();
	private bool save_;
	private bool load_;
	// Use this for initialization
	void Start () {
		save_ = false;
		load_ = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("player").GetComponent<Transform> ().position.y >= 1.1f && GameObject.Find ("player").GetComponent<Transform> ().position.x <= -7.7f) {
			GameObject.Find ("player").GetComponent<Transform> ().position = new Vector3 (0, 0, 0);
			save_ = true;
		} else {
			save_ = false;
		}
		if (GameObject.Find ("player").GetComponent<Transform> ().position.y >= 1.1f && GameObject.Find ("player").GetComponent<Transform> ().position.x >= 10.0f) {
			GameObject.Find ("player").GetComponent<Transform> ().position = new Vector3 (0, 0, 0);
			load_ = true;
		} else {
			load_ = false;
		}

		if (Input.GetKeyDown (KeyCode.S) || save_ == true) {
			//SaveClass.s = new SaveClass();
			GameObject.Find("_gameAsset").GetComponent<saveAsset>().save();
			GameObject.Find ("player").GetComponent<control_Player>().save();
			save();
			//print("S"+SaveClass.s.Splayer.x.ToString()+"//"+SaveClass.s.Splayer.y.ToString());

		}
		if (Input.GetKeyDown (KeyCode.D) || load_ == true) {
			load();
			//print("L"+SaveClass.s.Splayer.x.ToString()+"//"+SaveClass.s.Splayer.y.ToString());
			GameObject.Find ("player").GetComponent<control_Player>().load();
			GameObject.Find("_gameAsset").GetComponent<saveAsset>().load();

		}
	
	
	}
	void save(){

		if (savedGames.Count == 0) {
			savedGames.Add (SaveClass.s);
		}else{
			savedGames[0] = SaveClass.s;
		}

		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create (Application.persistentDataPath + "/savedGames.gd");
		bf.Serialize(file, savedGames);
		file.Close();
		print("done at " + Application.persistentDataPath + "/savedGames.gd");
	}
	void load(){
		try{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/savedGames.gd", FileMode.Open);
			savedGames = (List<SaveClass>)bf.Deserialize(file);
			SaveClass.s = savedGames[0];
			//print ()
			file.Close();

			print ("load done");

		}catch{
			print ("Error");
		}
	}
}
