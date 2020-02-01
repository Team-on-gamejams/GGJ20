using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class JournalButton : MonoBehaviour
{

    public Button Right;
    public Button Left;
    public AudioClip sound;
    public GameObject[] gameObjects;


    void Start()
    {
        Right = Right.GetComponent<Button>();
        Left = Left.GetComponent<Button>();
    }


    public void Press(bool isRight)
    {
        //AudioSource.PlayClipAtPoint(sound, transform.position);
        if (isRight)
        {
            
        }
        if (!isRight)
        {
            
        }
        
    }

    public void PageRight()
    {

    }

    public void PageLeft()
    {

    }
}
