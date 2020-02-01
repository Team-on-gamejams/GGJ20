using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButcherPlate : MonoBehaviour {
	[SerializeField] Transform organPos;
	Organ organ;

	public void OnClick() {
		if (GameManager.Instance.selectedTool != Tools.None && organ != null) {
			TryCraft();
		}
		else {
			Organ newOrgan = GameManager.Instance.organSlots.SelectedOrgan;
			int selectedSlot = GameManager.Instance.organSlots.GetSelectedId();
			GameManager.Instance.organSlots.SelectedOrgan = null;

			if (organ != null) {
				GameManager.Instance.organSlots.PlaceOrganAtPos(organ, selectedSlot);
				organ = null;
			}

			if (newOrgan != null) {
				newOrgan.transform.SetParent(organPos);
				LeanMover.Instance.Move(newOrgan.gameObject, organPos.position);
				organ = newOrgan;
			}
		}
	}

	public void TryCraft() {
		for (byte i = 0; i < organ.avaliableCrafts.Count; ++i) {
			if (organ.avaliableCrafts[i].tool == GameManager.Instance.selectedTool) {
				Organ newOrgan = Instantiate(organ.avaliableCrafts[i].result, organPos);
				newOrgan.name = organ.avaliableCrafts[i].result.name;
				newOrgan.SetRaycastTarget(false);
				Destroy(organ.gameObject);
				organ = newOrgan;
				return;
			}
		}
	}
}
