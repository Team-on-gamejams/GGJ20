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
	[SerializeField] LoseWindow loseWindow;
	[SerializeField] NextLevelWindow nextLevelWindow;
	[SerializeField] WinWindow winWindow;

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

	List<int> possiblePatients;
	public void InitLevel() {
		Level currLevel = Instantiate(levels[currentLevel]);
		levels[currentLevel] = currLevel;

		possiblePatients = new List<int>(patientUIs.Length);
		for (int i = 0; i < patientUIs.Length; ++i)
			possiblePatients.Add(i);

		for (byte i = 0; i < currLevel.patients.Length; ++i) {
			currLevel.patients[i] = Instantiate(currLevel.patients[i]);
			currLevel.patients[i].ui = GetRandomPatientUI();
		}

		topui.InitRooms(currLevel.patients, roomui);
	}

	public PatientUI GetRandomPatientUI() {
		int pos = Random.Range(0, possiblePatients.Count);
		int id = possiblePatients[pos];
		possiblePatients.RemoveAt(pos);
		return patientUIs[id];
	}

	public void OnOrganPlace() {
		if (levels[currentLevel].CheckWin()) { 
			if(currentLevel == levels.Length - 1) {
				winWindow.Show();
			}
			else {
				LeanTween.delayedCall(1.5f, ()=> {
					nextLevelWindow.Show();
				});
				nextLevelWindow.onNextClick = null;
				nextLevelWindow.onNextClick += () => {
					++currentLevel;
					InitLevel();
				};
			}
		}
	}

	public void OnWrongOrganPlace() {
		if (levels[currentLevel].RemoveHp()) {
			loseWindow.Show();
		}
	}
}
