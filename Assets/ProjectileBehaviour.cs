using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour {
	private GameObject _planet;
	private float _distance;
	private Rigidbody2D _rig;
	private float _gravityDistance;
	private float _forceAmount;
	private bool hit;
	[SerializeField]private float timer;
	[SerializeField]private float speed;
	void Start () {
		_planet = GameObject.Find ("Planet");
		_rig = GetComponent<Rigidbody2D> ();
		_gravityDistance = _planet.GetComponent<PlanetGravity> ().getGravityDistance;
		_forceAmount = _planet.GetComponent<PlanetGravity> ().getForceAmount;
	}

	void Update () {
		if (!hit) {
			_distance = Vector3.Distance (_planet.transform.position, transform.position);
			if (_distance <= _gravityDistance) {
				timer += Time.fixedDeltaTime; 
				print (timer);
				_forceAmount += timer;
				Vector3 _desiredDirection = _planet.transform.position - transform.position;
				_desiredDirection.Normalize ();
				_rig.AddForce (new Vector2 (_desiredDirection.x, _desiredDirection.y) * _forceAmount * (_distance / 5));
			}
			if (Input.GetKey (KeyCode.Space)) {
				_rig.AddForce (Vector2.up * speed);
			}
		}
	}
	void OnCollisionEnter2D(Collision2D other){
		hit = true;	
		_rig.velocity = new Vector2(0,0);
	}
}
