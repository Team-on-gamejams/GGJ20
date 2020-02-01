using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrganSlot : MonoBehaviour
{
    public bool IsAvaliable => organ == null;

    [NonSerialized] public Organ organ;

    [SerializeField] Image selectionImage;

    public void PlaceOrgan(Organ organ) {
        this.organ = organ;
        organ.transform.SetParent(transform);
        LeanMover.Instance.Move(organ.gameObject, transform.position);
    }

    public void Select() {
        selectionImage.gameObject.SetActive(true);
    }

    public void Unselect() {
        selectionImage.gameObject.SetActive(false);
    }
}
