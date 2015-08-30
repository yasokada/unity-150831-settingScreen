using UnityEngine;
using System.Collections;
using UnityEngine.UI;


/*
 * v0.1 2015/08/31
 *   - set and read Input Field
 */

public class RequesterScript : MonoBehaviour {

	public Text text_ipadr;

	void Start () {
	
	}
	
	void Update () {
		text_ipadr.text = ResponderScript.str_ipadr;
	}
}
