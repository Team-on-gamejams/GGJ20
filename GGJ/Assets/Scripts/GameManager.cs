using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public static GameManager Instance;

	public Tools selectedTool; //Set from right panel

	public Level[] levels;
	public Dictionary<Tools, byte> tools;

	public PatientUI[] patientUIs;
	public OrganSlotsHolder organSlots;

	[Header("Refs")]
	[SerializeField] TopUI topui;
	[SerializeField] RoomUI roomui;
	[SerializeField] RengenWindow rengenWindow;

	int currentLevel;

	private void Awake() {
		Instance = this;
		currentLevel = 0;
	}

	private void Start() {
		InitLevel();

		rengenWindow.onOrganPlace += OnOrganPlace;
		rengenWindow.onWrongOrganPlace += OnWrongOrganPlace;
	}

	public void InitLevel() {
		Level currLevel = Instantiate(levels[currentLevel]);
		levels[currentLevel] = currLevel;

		for (byte i = 0; i < currLevel.patients.Length; ++i) {
			currLevel.patients[i] = Instantiate(currLevel.patients[i]);
			currLevel.patients[i].ui = GetRandomPatientUI();
		}

		topui.InitRooms(currLevel.patients, roomui);
	}

	public PatientUI GetRandomPatientUI() {
		return patientUIs[Random.Range(0, patientUIs.Length)];
	}

	public void OnOrganPlace() {
		if (levels[currentLevel].CheckWin()) { 
			if(currentLevel == levels.Length - 1) {
				Debug.Log("Win game");
			}
			else {
				++currentLevel;
				InitLevel();
			}
		}
	}

	public void OnWrongOrganPlace() {
		if (levels[currentLevel].RemoveHp()) {
			Debug.Log("Lose game");
		}
	}

	public void LevelWin() {

	}

	public void LevelLose() {

	}
}
