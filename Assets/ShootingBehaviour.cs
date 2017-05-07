using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBehaviour : MonoBehaviour {

	private Vector3 _rot;
	private float _angle;
	private ProjectileBehaviour Projectilebehaviour;
	[SerializeField]private float _rotSpeed;
	[SerializeField]private float _shootSpeed;
	void Start () {
		Projectilebehaviour = GameObject.Find ("Test block").GetComponent<ProjectileBehaviour> ();
	}
	
	void Update () {
		_rot = new Vector3 (0, 0, _angle);
		transform.localEulerAngles = _rot;
		if (Input.GetKey (KeyCode.LeftArrow)) {
			_angle += _rotSpeed * Time.fixedDeltaTime;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			_angle -= _rotSpeed * Time.fixedDeltaTime;
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			Projectilebehaviour.Shoot (_shootSpeed);
		}
	}
}
