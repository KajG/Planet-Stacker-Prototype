using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffectProjectile : MonoBehaviour {

	private ParticleSystem projectileHittingPlanet;
	[SerializeField]private int particleAmountPlanetHit;
	void Start () {
		projectileHittingPlanet = GetComponent<ParticleSystem> ();
	}
	
	void Update () {
		
	}
	public void PlanetImpactParticles(int particleAmount, Vector3 pos){
		transform.position = pos;
		projectileHittingPlanet.Emit (particleAmount * 10);
	}
}
