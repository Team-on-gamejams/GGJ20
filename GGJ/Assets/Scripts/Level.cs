using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Level", menuName = "Level", order = 51)]
public class Level : ScriptableObject
{
	public Patient[] patients;
	public sbyte maxMistakes;

	public bool CheckWin() {
		foreach (var patient in patients) {
			if (!patient.IsRightOrgans())
				return false;
		}
		return true;
	}

	public bool RemoveHp() {
		return --maxMistakes == 0;
	}
}
