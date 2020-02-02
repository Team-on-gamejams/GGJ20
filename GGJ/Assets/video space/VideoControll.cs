using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoControll : MonoBehaviour
{
    // Start is called before the first frame update

    public VideoPlayer video;
    public VideoPlayer film;



    public void startFilm(){
        film.gameObject.SetActive(true);
        film.Play();
    }


    public void stopFilm(){
        film.gameObject.SetActive(false);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if(video.frame + 1 == (int)video.frameCount ){
             video.gameObject.SetActive(false);
        }

        if(film.frame + 1 == (int)film.frameCount){
             stopFilm();
        }
    }
}
