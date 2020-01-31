using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Organ : MonoBehaviour {
	public Tools extrectTool;
	public List<CraftData> avaliableCrafts;
}

[Serializable]
public struct CraftData {
	public Tools tool;
	public Organ result;
}
