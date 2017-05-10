using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBehaviour : MonoBehaviour{
	private GameObject _typeOfPlanet;
	private GameObject _cannon;
	private Transform _planetPosition;
	private Transform _cannonPosition;
	private int _amountOfAmmo;
	private int _desiredScore;
	public int getAmmo{get{return _amountOfAmmo;}}
	public int getScore{get{return _desiredScore;}}
	public void Level(int ammo, int maxScore, GameObject planet, GameObject cannon, Transform planetPos, Transform cannonPos){
		_cannon = cannon;
		_typeOfPlanet = planet;
		_amountOfAmmo = ammo;
		_desiredScore = maxScore;
		_cannonPosition = cannonPos;
		_planetPosition = planetPos;
	}
}
