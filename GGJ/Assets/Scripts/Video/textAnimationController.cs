using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textAnimationController : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        anim.Play("TextAnimation");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            anim.Play("fadeOutTextAnimation");
        }
        
        
    }
}
