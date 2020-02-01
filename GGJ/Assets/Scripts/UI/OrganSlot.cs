using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrganSlot : MonoBehaviour
{
    public bool IsAvaliable { get; set; }

    [SerializeField] Image selectionImage;

    Organ organ;

    private void Awake() {
        IsAvaliable = true;
    }

    public void PlaceOrgan(Organ organ) {
        this.organ = organ;
        organ.transform.SetParent(transform);
        organ.transform.position = transform.position;
        IsAvaliable = false;
    }

    public void Select() {
        selectionImage.gameObject.SetActive(true);
    }

    public void Unselect() {
        selectionImage.gameObject.SetActive(false);
    }
}
