using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomUI : MonoBehaviour
{
    [SerializeField] DocieWindow docieWindow;
    [SerializeField] RengenWindow rengenWindow;
    [SerializeField] JournalWindow journaWindow;

    [SerializeField] Image patientImage;
    Patient currPatient;

    public void ChangePatient(Patient patient) {
        currPatient = patient;
        patientImage.sprite = currPatient.ui.sprite;

        docieWindow.TryReInit(patient);
        rengenWindow.TryReInit(patient);
        journaWindow.TryReInit(patient);
    }

    public void OnDocieClick() {
        docieWindow.Show();
        docieWindow.ReInit(currPatient);
    }

    public void OnRengenClick() {
        rengenWindow.Show();
        rengenWindow.ReInit(currPatient);
    }

    public void OnJournalClick() {
        journaWindow.Show();
        journaWindow.ReInit(currPatient);
    }
}
