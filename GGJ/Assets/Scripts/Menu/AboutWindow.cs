using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutWindow : MonoBehaviour
{
    public GameObject wnd;

    public void showWnd(){
        wnd.SetActive(true);
    }
    public void hideWnd(){
        wnd.SetActive(false);
    }
}
