using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum1 : MonoBehaviour {

	Quaternion _start, _end;
	public bool go = false;

	[SerializeField, Range(0.0f,360f)]
	private float _angle = 90.0f;

	[SerializeField, Range(0.0f,5.0f)]
	private float _speed = 0.0f;

	[SerializeField, Range(0.0f,10.0f)]
	private float _startTime = 0.0f;


	private void Start () {

		_start = PendulumRotation (_angle);
		_end = PendulumRotation (-_angle);

	}

	private void FixedUpdate()
	{
		
		transform.rotation = Quaternion.Lerp (_start, _end, (Mathf.Sin (_startTime * _speed + Mathf.PI / 2) + 1.0f) / 2.0f);
		_startTime += Time.deltaTime;
	}

	void ResetTimer()
	{
		_startTime = 0.0f;

	}

	Quaternion PendulumRotation(float angle){

		var pendulumRotation = transform.rotation;
		var angleX = pendulumRotation.eulerAngles.x + angle;

		if (angleX > 180)
			angleX -= 360;
		else if (angleX < -180)
			angleX += 360;

		pendulumRotation.eulerAngles = new Vector3 (angleX, pendulumRotation.eulerAngles.y,pendulumRotation.eulerAngles.z );
		return pendulumRotation;
	}

	void Update () {
		//Start input
		if (go == true) {
			_speed = 2.0f;
		
		} else {
			_startTime = 0;
		}
	}
}

	

