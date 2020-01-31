using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RengenWindow : BaseWindow {
	[SerializeField] GameObject rengenParent;

	public override void ReInit(Patient patient) {
		base.ReInit(patient);
		
		Transform[] childs = rengenParent.transform.GetComponentsInChildren<Transform>();
		for(byte i = 1; i < childs.Length; ++i)
			Destroy(childs[i].gameObject);

		Instantiate(patient.ui.rengenPrefab, rengenParent.transform);
	}
}
