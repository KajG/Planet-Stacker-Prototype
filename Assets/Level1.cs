using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour {
	[SerializeField]protected GameObject _typeOfPlanet;
	[SerializeField]protected GameObject _cannon;
	[SerializeField]protected Transform _planetPosition;
	[SerializeField]protected Transform _cannonPosition;
	[SerializeField]protected int _amountOfAmmo;
	[SerializeField]protected int _desiredScore;
	void Awake () {
		new LevelBehaviour (_amountOfAmmo, _desiredScore, _typeOfPlanet, _cannon, _planetPosition, _cannonPosition);
	}
	
	void Update () {
		
	}
}
