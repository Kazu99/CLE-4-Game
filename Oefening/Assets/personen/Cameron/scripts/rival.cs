using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rival : MonoBehaviour {
	public float rayHeight = 0.5f;
	public float momentum, maxmomentum = 77, accel, grip;
	public float gravity = 10;
	Rigidbody me;
	Transform nextWaypoint;
	// Use this for initialization
	void Start () {
		me = gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	float Timer = 0.5f;
	void Update () {
		Timer -= Time.deltaTime;
		if (momentum != 0) {
			momentum = Mathf.Lerp (momentum, 0, grip * Time.deltaTime / momentum);
		}
		me.MovePosition(transform.position + transform.forward * momentum * Time.deltaTime);
		me.velocity -= Vector3.up * gravity * Time.deltaTime;
		detectGround ();
		drive ();

		if(Timer < 0 && nextWaypoint != null) {
			Timer = 0.5f;
		}
		if(Timer < 0.25f) {
			Quaternion r = transform.rotation;
			transform.LookAt (nextWaypoint);
			transform.rotation = Quaternion.Lerp (r, transform.rotation, Time.deltaTime*5);
		}
	}

	void drive () {
		Ray ray = new Ray (transform.position, transform.forward);
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit, 7)) {
			momentum = 0;
		} else if (momentum < maxmomentum && nextWaypoint != null) {
			momentum += Time.deltaTime * accel;
		}
	}

	void detectGround () {
		Ray ray = new Ray (transform.position, -transform.up);
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit, rayHeight)) {
			Quaternion x = Quaternion.Euler (0, transform.rotation.eulerAngles.y ,0);
			transform.rotation = Quaternion.Lerp (transform.rotation, x, Time.deltaTime/2.5f);
		}
	}

	void OnTriggerEnter (Collider coll) {
		if (coll.tag == "waypoint" && coll.gameObject.GetComponent<waypoint>() != null) {
			nextWaypoint = coll.gameObject.GetComponent<waypoint> ().nextPoint[Random.Range(0, coll.gameObject.GetComponent<waypoint> ().nextPoint.Length)];
			if(coll.gameObject.GetComponent<waypoint> ().changeSpeed) {
				maxmomentum = coll.gameObject.GetComponent<waypoint> ().maxSpeed;
			}
			transform.LookAt (nextWaypoint);
		} else if (coll.tag == "waypoint" && coll.gameObject.GetComponent<waypoint>() == null) {
			nextWaypoint = null;
		} 
	}
}
