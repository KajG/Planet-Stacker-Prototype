using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour {
	private GameObject _planet;
	private Transform _cannonPos;
	private Rigidbody2D _rig;
	private ParticleEffectProjectile _particleEffect;
	private float _distance;
	private float _gravityDistance;
	private float _forceAmount;
	private bool hit;
	private bool gotShot;
	[SerializeField]private float timer;
	[SerializeField]private float speed;
	[SerializeField]private float _forceGroundTime;
	[SerializeField]private int _spawnAmount;
	void Start () {
		_cannonPos = GameObject.Find ("Cannon").GetComponent<Transform> ();
		_planet = GameObject.Find ("Planet");
		_rig = GetComponent<Rigidbody2D> ();
		_particleEffect = GameObject.Find ("ParticlePlanetHit").GetComponent<ParticleEffectProjectile> ();
		_gravityDistance = _planet.GetComponent<PlanetGravity> ().getGravityDistance;
		_forceAmount = _planet.GetComponent<PlanetGravity> ().getForceAmount;
	}

	void Update () {
		float AngleRad = Mathf.Atan2(_planet.transform.position.y - transform.position.y, _planet.transform.position.x - transform.position.x);
		float AngleDeg = (180 / Mathf.PI) * AngleRad;
		this.transform.rotation = Quaternion.Euler(0, 0, AngleDeg);
		if (!hit && gotShot) {
			_distance = Vector3.Distance (_planet.transform.position, transform.position);
			if (_distance <= _gravityDistance) {
				timer += Time.fixedDeltaTime / _forceGroundTime; 
				print (timer);
				_forceAmount += timer;
				Vector3 _desiredDirection = _planet.transform.position - transform.position;
				_desiredDirection.Normalize ();
				_rig.AddForce (new Vector2 (_desiredDirection.x, _desiredDirection.y) * _forceAmount * (_distance / 5));
			}
		} else if(!gotShot){
			transform.position = _cannonPos.position;
			transform.rotation = _cannonPos.rotation;
		}
	}
	void OnCollisionEnter2D(Collision2D other){
		hit = true;	
		Destroy (_rig);
		if (other.gameObject.tag == "Planet") {
			_particleEffect.PlanetImpactParticles ((int)_spawnAmount, transform.position);
			SpawnEntity ();
			Destroy (GetComponent<ProjectileBehaviour> ());
		}
	}
	void SpawnEntity(){
		for (int i = 1; i < _spawnAmount + 1; i++) {
			GameObject obj = Instantiate (gameObject, transform.position + transform.right * -i, transform.rotation);
			Destroy (obj.GetComponent<ProjectileBehaviour> ());
			Destroy (obj.GetComponent<Rigidbody2D> ());
		}
	}
	public void Shoot(float _shotSpeed){
		gotShot = true;
		_rig.AddForce (transform.up * _shotSpeed);
	}
}
