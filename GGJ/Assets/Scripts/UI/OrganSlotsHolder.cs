using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganSlotsHolder : MonoBehaviour {
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
