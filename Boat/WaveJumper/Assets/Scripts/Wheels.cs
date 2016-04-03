using UnityEngine;
using System.Collections;

public class RotorRotator : MonoBehaviour {

	// Update is called once per frame
	void Update () 
	{
		 if ( Input.GetKey("w"))
		{
			this.transform.Rotate(0,0, -(Time.deltaTime * 50)-10 );         	//	roatate the Rotor
		}
		if ( Input.GetKey("s"))
		{
			this.transform.Rotate(0,0, (Time.deltaTime * 25)+5 );	            //rotate the rotor
		}
	}
}
