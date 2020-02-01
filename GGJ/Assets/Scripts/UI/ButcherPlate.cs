using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButcherPlate : MonoBehaviour
{
    [SerializeField] Transform organPos;
    Organ organ;

    public void OnClick() {
        Organ newOrgan = GameManager.Instance.organSlots.SelectedOrgan;
        int selectedSlot = GameManager.Instance.organSlots.GetSelectedId();
        GameManager.Instance.organSlots.SelectedOrgan = null;

        if(organ != null) {
            GameManager.Instance.organSlots.PlaceOrganAtPos(organ, selectedSlot);
            organ = null;
        }

        if(newOrgan != null) {
            newOrgan.transform.SetParent(organPos);
            newOrgan.transform.position = organPos.position;
            organ = newOrgan;
        }
    }
}
