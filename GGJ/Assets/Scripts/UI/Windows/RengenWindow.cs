using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RengenWindow : BaseWindow {
	[SerializeField] GameObject rengenParent;
	[SerializeField] OrganSlotsHolder organSlotsHolder;
	Organ[] organs;

	public override void ReInit(Patient patient) {
		base.ReInit(patient);

		Transform[] childs = rengenParent.transform.GetComponentsInChildren<Transform>();
		for (byte i = 1; i < childs.Length; ++i)
			Destroy(childs[i].gameObject);

		OrganPosHolder organPosHolder = Instantiate(patient.ui.rengenPrefab, rengenParent.transform).GetComponent<OrganPosHolder>();

		organs = new Organ[patient.organs.Length];
		for (byte i = 0; i < patient.organs.Length; ++i) {
			if(patient.organs[i] != null) {
				Organ organ = Instantiate(patient.organs[i], organPosHolder.organPos[i]);
				organ.SetRaycastTarget(false);
				organPosHolder.organPos[i] = null;
				organPosHolder.onClickAction[i] += MoveOrganToSlot;

				organs[i] = organ;
			}
		}
	}

	void MoveOrganToSlot(int id) {
		if(patient.organs[id] != null && patient.organs[id].IsRightExtractTool(GameManager.Instance.selectedTool) && organSlotsHolder.IsAvaliableSlot()) {
			organSlotsHolder.PlaceOrganFirstAvaliable(organs[id]);
			organs[id] = patient.organs[id] = null;
		};
	}
}
