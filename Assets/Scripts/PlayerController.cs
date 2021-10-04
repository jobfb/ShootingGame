using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
	Rigidbody myRigidbody;
	Vector3 velocity;
	void Start()
	{
		myRigidbody = GetComponent<Rigidbody>();
	}
	public void Move(Vector3 _velocity)
	{
		velocity = _velocity;
	}

	public void LookAt(Vector3 lookPoint)
	{
		Vector3 heightCorrectedPoint = new Vector3(lookPoint.x,transform.position.y,lookPoint.z);//without this the player will rotate when the mouse move
		transform.LookAt (heightCorrectedPoint);
	}
	public void FixedUpdate()//Keep uptading from small periods of time 
	{
		myRigidbody.MovePosition(myRigidbody.position + velocity * Time.fixedDeltaTime);
	}
 
}
