using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slagboom : MonoBehaviour {

	public float maxTimer;
	float Timer;
	public Transform arm;
	public float speed;

	// Update is called once per frame
	void Update () {
		Timer += Time.deltaTime;
		if (Timer > maxTimer) {
			Timer = 0;
		}

		if (Timer < maxTimer / 4) {
			arm.localRotation = Quaternion.Euler (0,0,0);
		} else if (Timer < maxTimer / 2) {
			arm.localRotation = Quaternion.Lerp (arm.localRotation, Quaternion.Euler(0,0,-45), speed * Time.deltaTime);
		} else if (Timer < (maxTimer / 4) * 3) {
			arm.localRotation = Quaternion.Euler (0,0,-45);
		} else {
			arm.localRotation = Quaternion.Lerp (arm.localRotation, Quaternion.Euler(0,0,0), speed * Time.deltaTime);
		}
	}


}
