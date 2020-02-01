using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Tools selectedTool; //Set from right panel

    public Level[] levels;
    public Dictionary<Tools, byte> tools;

    public PatientUI[] patientUIs;
    public OrganSlotsHolder organSlots;

    [Header("Refs")]
    [SerializeField] TopUI topui;
    [SerializeField] RoomUI roomui;

    int currentLevel;

    private void Awake() {
        Instance = this;
        currentLevel = 0;
    }

    private void Start() {
        InitLevel();
    }

    public void InitLevel() {
        Level currLevel = Instantiate(levels[currentLevel]);

        for (byte i = 0; i < currLevel.patients.Length; ++i) {
            currLevel.patients[i] = Instantiate(currLevel.patients[i]);
            currLevel.patients[i].ui = GetRandomPatientUI();
        }

        topui.InitRooms(currLevel.patients, roomui);
    }

    public PatientUI GetRandomPatientUI() {
        return patientUIs[Random.Range(0, patientUIs.Length)];
    }
}
