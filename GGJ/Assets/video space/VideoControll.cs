using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoControll : MonoBehaviour
{
    // Start is called before the first frame update

    public VideoPlayer video;
    void Start()
    {
 
        // Debug.Log(video.frameCount);
    }

    // Update is called once per frame
    void Update()
    {

    // Debug.Log( video.frame);

        if(video.frame + 1 == (int)video.frameCount ){
             video.gameObject.SetActive(false);
        }
    }
}
