using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class JournalButton : MonoBehaviour
{

    public Button Right;
    public Button Left;
    public AudioClip sound;
    public Animator ani;



    void Start()
    {
        Right = Right.GetComponent<Button>();
        Left = Left.GetComponent<Button>();
        ani.GetComponent<Animator>();
    }


    public void Press(bool isRight)
    {
        //AudioSource.PlayClipAtPoint(sound, transform.position);
        if (isRight)
        {
            Right.enabled = true;
            if (ani.GetInteger("Page") < 2)
                ani.SetInteger("Page", ani.GetInteger("Page") + 1);
        }
        if (!isRight)
        {
            Left.enabled = true;
            if (ani.GetInteger("Page") > 0)
                ani.SetInteger("Page", ani.GetInteger("Page") - 1);
        }
        
    }
}
