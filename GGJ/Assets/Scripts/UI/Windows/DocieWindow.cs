using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DocieWindow : BaseWindow
{

    public Text txt;
    public override void ReInit(Patient patient)
    {
        base.ReInit(patient);
        txt.text = patient.docie.name[Random.Range(0, patient.docie.name.Length)]+"\n"+ patient.docie.galaxy[1]+"\n" + patient.docie.planet[1] + "\n" + patient.docie.adress[1] + "\n" + patient.docie.phone[1] + "\n" + patient.docie.birth[1] + "\n" + patient.docie.race[1] + "\n" + patient.docie.gander[1] + "\n" + patient.docie.sympthoms[1];
    }
}
