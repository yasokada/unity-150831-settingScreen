using UnityEngine;
using System.Collections;

public class ResponderScript : MonoBehaviour {

	void Start () {
		DontDestroyOnLoad (this); // to access public static variables from other scene	
	}
	
	void Update () {
	
	}
}
