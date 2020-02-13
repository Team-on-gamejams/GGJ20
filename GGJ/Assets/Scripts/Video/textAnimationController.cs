using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textAnimationController : MonoBehaviour
{
    private Animator anim;
    int q = 0;
    public string[] texts;
    public Text outText;
    public float delay;
    private bool isShow = false;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        outText.text = texts[q];
        InvokeRepeating("writeText", 1f, delay);
    }

    
    void writeText(){

        if(q < texts.Length){
            if(isShow){
                anim.Play("fadeOutTextAnimation");             
            }else{
                outText.text = texts[q];
                anim.Play("TextAnimation");
                q++;
            }
            isShow = !isShow;
        }           
           
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            anim.Play("fadeOutTextAnimation");
        }
        
        
    }
}
