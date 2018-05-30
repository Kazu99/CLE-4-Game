using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class culling : MonoBehaviour {

	public float dist;
	public GameObject [] g;
	public MeshRenderer [] mr;
	public MonoBehaviour[] mb;

	bool b;

	void Update () {

		if (GameObject.Find ("Main Camera") != null && Vector3.Distance (GameObject.Find ("Main Camera").transform.position, transform.position) > dist) {
			b = true;
			foreach (GameObject x in g) {
				x.SetActive (false);
			}
			foreach (MeshRenderer x in mr) {
				x.enabled = false;
			}
			foreach (MonoBehaviour x in mb) {
				x.enabled = false;
			}
		} else if (b) {
			foreach (GameObject x in g) {
				x.SetActive (true);
			}
			foreach (MeshRenderer x in mr) {
				x.enabled = true;
			}
			foreach (MonoBehaviour x in mb) {
				x.enabled = true;
			}
			b = false;
		}

	}
}
