using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Patient", menuName = "Patient", order = 51)]
public class Patient : ScriptableObject
{
    public Docie docie;
    public Organ[] organs;
    public OrganTypes[] neededOrgans;
    [NonSerialized] public PatientUI ui;

    public bool IsRightOrgans() {
        List<OrganTypes> organsList = new List<OrganTypes>(neededOrgans);

        for(byte i = 0; i < organs.Length; ++i) {
            if(organs[i] == null)
                return false;
            if (organsList.Contains(organs[i].organType)) {
                organsList.Remove(organs[i].organType);
            }
            else {
                return false;
            }
        }
        return true; 
    }
}
