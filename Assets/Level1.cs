using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour {
	[SerializeField]private GameObject _typeOfPlanet;
	[SerializeField]private GameObject _cannon;
	[SerializeField]private Transform _planetPosition;
	[SerializeField]private Transform _cannonPosition;
	[SerializeField]private int _amountOfAmmo;
	[SerializeField]private int _desiredScore;
	private LevelBehaviour Levelbehaviour;
	void Awake () {
		Levelbehaviour = GetComponent<LevelBehaviour> ();
		Levelbehaviour.Level (_amountOfAmmo, _desiredScore, _typeOfPlanet, _cannon, _planetPosition, _cannonPosition);
	}
}
