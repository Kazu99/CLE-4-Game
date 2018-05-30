using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class fence : MonoBehaviour {

	public LineRenderer lr;
	public List<Vector3> tr;

	void Start () {
		lr = gameObject.GetComponent<LineRenderer> ();

		tr = new List<Vector3>();

		for (int i = 0; i < transform.childCount; i++) {
			tr.Add (transform.GetChild(i).localPosition);
		}

		lr.numPositions = tr.ToArray().Length;
		lr.SetPositions (tr.ToArray());
	}

	/*void Update () {
		if (Application.isEditor) {
			tr = new List<Vector3> ();

			for (int i = 0; i < transform.childCount; i++) {
				tr.Add (transform.GetChild (i).localPosition);
			}

			lr.numPositions = tr.ToArray ().Length;
			lr.SetPositions (tr.ToArray ());
		}
	}*/
}
