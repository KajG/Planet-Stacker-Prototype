using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBehaviour : MonoBehaviour {

	private Vector3 _rot;
	private float _angle;
	private ProjectileBehaviour Projectilebehaviour;
	private AmmoBehaviour Ammobehaviour;
	[SerializeField]private float _rotSpeed;
	[SerializeField]private float _shootSpeed;
	void Start () {
		Projectilebehaviour = GameObject.Find ("Test block").GetComponent<ProjectileBehaviour> ();
		Ammobehaviour = GameObject.Find ("Cannon").GetComponent<AmmoBehaviour> ();
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
		if (Ammobehaviour._fullAmmo.Count > 0) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				Projectilebehaviour.Shoot (_shootSpeed);
				Destroy (Ammobehaviour._fullAmmo [0]);
				Ammobehaviour._fullAmmo.RemoveAt (0);
				GameObject obj = Instantiate (Ammobehaviour.getAmmoObj, transform.position, Quaternion.identity);
				Projectilebehaviour = GameObject.Find ();
			}
		}
	}
}
