using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BookController : MonoBehaviour
{

    public Button Right;
    public Button Left;
    public AudioClip sound;
    public int page = 0;
    public GameObject[] pages;

    public void ButtonRight()
    {
        if (page < pages.Length-1)
        {
            page++;
            Left.gameObject.SetActive(true);
        }
        if (page == pages.Length-1)
            Right.gameObject.SetActive(false);
    }

    public void ButtonLeft()
    {
        if (page > 0)
        {
            page--;
            Right.gameObject.SetActive(true);
        }
        if (page == 0)
            Left.gameObject.SetActive(false);
    }

    void Start()
    {
        Right = Right.GetComponent<Button>();
        Left = Left.GetComponent<Button>();
        pages[0].SetActive(true);
    }

    public void Press(bool isRight)
    {
        //AudioSource.PlayClipAtPoint(sound, transform.position);
        pages[page].SetActive(false);
        if (isRight)
            ButtonRight();
        if (!isRight)
            ButtonLeft();
        pages[page].SetActive(true);

    }

}
