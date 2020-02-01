using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganSlotsHolder : MonoBehaviour {
	[SerializeField] OrganSlot[] organSlots;

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
}
