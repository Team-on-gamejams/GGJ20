using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Tools selectedTool; //Set from right panel

    public Level[] levels;
    public Dictionary<Tools, byte> tools;

    public PatientUI[] patientUIs;

    [Header("Refs")]
    [SerializeField] TopUI topui;
    [SerializeField] RoomUI roomui;

    int currentLevel;

    private void Awake() {
        currentLevel = 0;
    }

    private void Start() {
        InitLevel();
    }

    public void InitLevel() {
        Level currLevel = levels[currentLevel];

        foreach (var patient in currLevel.patients) {
            patient.ui = GetRandomPatientUI();
        }

        topui.InitRooms(currLevel.patients, roomui);
    }

    public PatientUI GetRandomPatientUI() {
        return patientUIs[Random.Range(0, patientUIs.Length)];
    }
}
