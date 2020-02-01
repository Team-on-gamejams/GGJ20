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

    public void InitRoom(Patient patient) {
        this.patient = patient;

        text.text = patient.docie.name + "\n";
        text.text += patient.docie.neededOrgs + "\n";
        patientSprite.sprite = patient.ui.sprite;
    }
}
