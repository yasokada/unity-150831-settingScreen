using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RequesterScript : MonoBehaviour {

	public Text text_ipadr;

	void Start () {
	
	}
	
	void Update () {
		text_ipadr.text = ResponderScript.str_ipadr;
	}
}
