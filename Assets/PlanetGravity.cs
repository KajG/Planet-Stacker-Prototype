using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGravity : MonoBehaviour {
	[SerializeField]private float _gravityDistance;
	[SerializeField]private float _forceAmount;
	[SerializeField]private GameObject _planetGizmo;
	public float getGravityDistance{get{return _gravityDistance;}}
	public float getForceAmount{get{return _forceAmount;}}
	void OnDrawGizmos(){
		Gizmos.color = Color.white;
		Gizmos.DrawSphere (_planetGizmo.transform.position, _gravityDistance);
	}
}
