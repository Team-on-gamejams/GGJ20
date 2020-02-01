using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganSlotsHolder : MonoBehaviour {
	public Organ SelectedOrgan {
		get => selecedSlot == -1 ? null : organSlots[selecedSlot].organ;
		set {
			if (selecedSlot != -1) {
				organSlots[selecedSlot].Unselect();
				organSlots[selecedSlot].organ = null;
				selecedSlot = -1;
			}
		}
	}

	[SerializeField] OrganSlot[] organSlots;
	int selecedSlot = -1;

	private void Awake() {
		foreach (var slot in organSlots) {
			slot.Unselect();
		}
	}

	public bool IsAvaliableSlot() {
		for (byte i = 0; i < organSlots.Length; ++i)
			if (organSlots[i].IsAvaliable)
				return true;
		return false;
	}

	public void PlaceOrganFirstAvaliable(Organ organ) {
		for (byte i = 0; i < organSlots.Length; ++i) {
			if (organSlots[i].IsAvaliable) {
				organSlots[i].PlaceOrgan(organ);
				return;
			}
		}
	}

	public void PlaceOrganAtPos(Organ organ, int pos) {
		if(pos != -1) {
			organSlots[pos].PlaceOrgan(organ);
		}
		else {
			PlaceOrganFirstAvaliable(organ);
		}
	}

	public int GetSelectedId() => selecedSlot;

	public void OnSlotClick(int id) {
		if (selecedSlot != id) {
			if (!organSlots[id].IsAvaliable) {
				if (selecedSlot != -1)
					organSlots[selecedSlot].Unselect();
				selecedSlot = id;
				organSlots[selecedSlot].Select();
			}
		}
		else {
			if (selecedSlot != -1) {
				organSlots[selecedSlot].Unselect();
				selecedSlot = -1;
			}
		}
	}
}
