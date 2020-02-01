using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganSlot : MonoBehaviour
{
    public bool IsAvaliable { get; set; }
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
}
