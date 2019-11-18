using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{
    private VideoPlayer Video;
    public GameObject ButtonPlay;
    public GameObject ButtonPause;
    public GameObject CanvasVideoPlayer;

    
    // Start is called before the first frame update
    void Start()
    {
        Video = this.gameObject.GetComponent<VideoPlayer>();
        Video.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnTriggerEnter(Collider other)
    {
            Video.Play();
            ButtonPlay.SetActive(false);
            ButtonPause.SetActive(true);
            //CanvasVideoPlayer.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
            Video.Stop();
            ButtonPlay.SetActive(true);
            ButtonPause.SetActive(false);
            //CanvasVideoPlayer.SetActive(false);
    }
}
