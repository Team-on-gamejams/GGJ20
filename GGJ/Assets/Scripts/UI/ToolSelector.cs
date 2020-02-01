using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolSelector : MonoBehaviour
{
    public Image selectionImage;
    public Tools toolType;

    public void Select() {
        selectionImage.gameObject.SetActive(true);
    }

    public void Unselect() {
        selectionImage.gameObject.SetActive(false);
    }
}
