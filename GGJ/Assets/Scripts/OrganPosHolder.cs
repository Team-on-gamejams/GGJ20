using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganPosHolder : MonoBehaviour
{
    public Action<int>[] onClickAction;
    public Transform[] organPos;

    public void Awake() {
        onClickAction = new Action<int>[organPos.Length];
    }

    public void OnClick(int id) {
        onClickAction[id]?.Invoke(id);
    }
}
