using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResponderScript : MonoBehaviour {

	public InputField IF_ipadr;
	public static string str_ipadr = "";

	void Start () {
		DontDestroyOnLoad (this); // to access public static variables from other scene	
		loadOldSetting ();
	}

	void loadOldSetting() {
		IF_ipadr.text = str_ipadr;
	}

	void OnGUI() {
		if (str_ipadr.Equals (IF_ipadr.text) == false) {
			str_ipadr = IF_ipadr.text;
		}
	}
}
