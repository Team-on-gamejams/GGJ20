using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TopRoom : MonoBehaviour
{
    public Patient patient;

    [Header("Refs")]
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] Image patientSprite;
    [SerializeField] GameObject closedObj;

    public void InitRoom(Patient patient) {
        if(patient == null) {
            patientSprite.color = Color.clear;
            closedObj.SetActive(true);
        }
        else {
            this.patient = patient;

            text.text = patient.docie.name + "\n";
            text.text += patient.docie.neededOrgs + "\n";
            patientSprite.color = Color.white;
            patientSprite.sprite = patient.ui.sprite;

            closedObj.SetActive(false);
        }
    }
}
