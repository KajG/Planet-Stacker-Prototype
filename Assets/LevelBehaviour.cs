using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBehaviour : Component{
	[SerializeField]protected GameObject _typeOfPlanet;
	[SerializeField]protected GameObject _cannon;
	[SerializeField]protected Transform _planetPosition;
	[SerializeField]protected Transform _cannonPosition;
	[SerializeField]protected int _amountOfAmmo;
	public int getAmmo{get{return _amountOfAmmo;}}
	[SerializeField]protected int _desiredScore;
	public int getScore{get{return _desiredScore;}}
	public LevelBehaviour(int ammo, int maxScore, GameObject planet, GameObject cannon, Transform planetPos, Transform cannonPos){
		_cannon = cannon;
		_typeOfPlanet = planet;
		_amountOfAmmo = ammo;
		_desiredScore = maxScore;
		_cannonPosition = cannonPos;
		_planetPosition = planetPos;
	}
}
