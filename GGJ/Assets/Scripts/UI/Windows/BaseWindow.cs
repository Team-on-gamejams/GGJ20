using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWindow : MonoBehaviour
{
    public bool isShowed = false;
    protected Patient patient;

    public void Show() {
        gameObject.SetActive(true);
        isShowed = true;
    }

    public void Close() {
        gameObject.SetActive(false);
        isShowed = false;
    }

    public void TryReInit(Patient patient) {
        if (isShowed)
            ReInit(patient);
    }

    public virtual void ReInit(Patient patient) {
        this.patient = patient;
    }
}
