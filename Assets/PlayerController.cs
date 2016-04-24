using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float torque;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float turn = Input.GetAxis("Horizontal");

		//Debug.Log (turn);

		Vector3 twist = new Vector3 (0.0f, turn, 0.0f);

		rb.AddTorque(twist * torque);

		float throttle = Input.GetAxis ("Vertical");

		//Debug.Log (transform.rotation.y);

		Vector3 movement = new Vector3 (Mathf.Cos(transform.rotation.y), 0.0f, Mathf.Sin(transform.rotation.y));

		rb.AddForce (movement * speed * throttle);
	}
}
