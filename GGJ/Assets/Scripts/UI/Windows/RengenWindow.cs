using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RengenWindow : BaseWindow {
	[SerializeField] GameObject rengenParent;
	[SerializeField] OrganSlotsHolder organSlotsHolder;

	OrganPosHolder organPosHolder;
	Organ[] organs;

	public override void ReInit(Patient patient) {
		base.ReInit(patient);

		Transform[] childs = rengenParent.transform.GetComponentsInChildren<Transform>();
		for (byte i = 1; i < childs.Length; ++i)
			Destroy(childs[i].gameObject);

		organPosHolder = Instantiate(patient.ui.rengenPrefab, rengenParent.transform).GetComponent<OrganPosHolder>();

		organs = new Organ[patient.organs.Length];
		for (byte i = 0; i < patient.organs.Length; ++i) {
			if (patient.organs[i] != null) {
				Organ organ = Instantiate(patient.organs[i], organPosHolder.organPos[i]);
				organ.SetRaycastTarget(false);
				organPosHolder.onClickAction[i] += ProcessClickOnRengen;

				organs[i] = organ;
			}
		}
	}

	void ProcessClickOnRengen(int id) {
		if (patient.organs[id] != null) {
			if (organSlotsHolder.IsAvaliableSlot()) {
				if (patient.organs[id].IsRightExtractTool(GameManager.Instance.selectedTool)) {
					MoveOrganToSlot(id);
				}
				else {

				}
			}
		}
		else {
			if (GameManager.Instance.organSlots.SelectedOrgan != null)
				MoveOrganFromHolder(id);
		}
	}

	void MoveOrganToSlot(int id) {
		organSlotsHolder.PlaceOrganFirstAvaliable(organs[id]);
		organs[id] = patient.organs[id] = null;
	}

	void MoveOrganFromHolder(int id) {
		Organ newOrgan = GameManager.Instance.organSlots.SelectedOrgan;
		GameManager.Instance.organSlots.SelectedOrgan = null;

		newOrgan.transform.SetParent(organPosHolder.organPos[id]);
		newOrgan.transform.position = organPosHolder.organPos[id].position;
		patient.organs[id] = organs[id] = newOrgan;
	}
}
