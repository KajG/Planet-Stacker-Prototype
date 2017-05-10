using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBehaviour : MonoBehaviour {
	private LevelBehaviour Levelbehaviour;
	[SerializeField]private GameObject _ammo;
	public GameObject getAmmoObj;
	public List<GameObject> _fullAmmo = new List<GameObject>();
	void Start () {
		Levelbehaviour = GameObject.Find ("Main Camera").GetComponent<LevelBehaviour> ();
		for (int i = 0; i < Levelbehaviour.getAmmo; i++) {
			_fullAmmo.Add (_ammo);
		}
	}
	
	void Update () {
		
	}
}
