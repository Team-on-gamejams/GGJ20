using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Tools selectedTool; //Set from right panel

    public Level[] levels;
    public Dictionary<Tools, byte> tools;

}
