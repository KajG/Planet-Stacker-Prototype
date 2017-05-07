using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBehaviour : MonoBehaviour {
	private LevelBehaviour Levelbehaviour;
	private List<GameObject> _ammo = new List<GameObject>();
	void Start () {
		Levelbehaviour = GameObject.Find ("Main Camera").GetComponent<LevelBehaviour> ();
	}
	
	void Update () {
		print (Levelbehaviour.getAmmo);
	}
}
