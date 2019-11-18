using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{
    private VideoPlayer Video;
    
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

    /*void OnTriggerStay(Collider other)
    {
       Debug.Log("funca");
    }*/

    private void OnTriggerEnter(Collider other)
    {
            Video.Play();
    }

    private void OnTriggerExit(Collider other)
    {
            Video.Pause();
    }
}
