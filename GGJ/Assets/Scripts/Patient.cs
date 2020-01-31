using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Patient", menuName = "Patient", order = 51)]
public class Patient : ScriptableObject
{
    public Docie docie;
    public Organ[] organs;
}
