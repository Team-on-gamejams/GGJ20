using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Organ : MonoBehaviour {
	public OrganTypes organType;
	public Tools extrectTool;
	public List<CraftData> avaliableCrafts;

	[SerializeField] Image organImage;

	public bool IsRightExtractTool(Tools tool) {
		return tool == extrectTool;
	}

	public void SetRaycastTarget(bool isTarget) {
		organImage.raycastTarget = isTarget;
		Image[] transforms = GetComponentsInChildren<Image>();
		foreach (var t in transforms) {
			t.raycastTarget = isTarget;
		}
	}
}

[Serializable]
public struct CraftData {
	public Tools tool;
	public Organ result;
}
