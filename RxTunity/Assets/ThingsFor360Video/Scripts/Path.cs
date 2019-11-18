using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Path : MonoBehaviour
{
    public Transform[] target;
    public VideoPlayer[] VideoArray;
    private float speed;
    public float velocity;
    public GameObject PlayButton;
    public GameObject PauseButton;

    private bool ItCanMove;

    private int current;
    // Start is called before the first frame update
    void Start()
    {
        PauseButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {   //move until you reach the current object/waypoint
        
        if(transform.position != target[current].position )
        {
            Vector3 pos = Vector3.MoveTowards(transform.position , target[current].position , speed*Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);

        } //object/waypoint reached, move to the next object 
        else speed=0; //current = ( current + 1) % target.Length;
        Debug.Log(current);
        
    }

    public void ButtonMoveForward(){
        current+=1;

        if(current < target.Length){
            speed=velocity;
            
        }else if(current>=target.Length){
            current=0;
            speed=velocity*1;
        }

    }

    public void ButtonMoveBackward(){
        current-=1;

          if(current >= 0){            
              speed=velocity*1;
        }else if(current<0){          
            current= target.Length-1;
            speed=velocity*1;
        }
    }

     public void ButtonPlay(){
        PlayButton.SetActive(false);
        PauseButton.SetActive(true);
        VideoArray[current].Play();
     
    }

     public void ButtonPause(){
        PauseButton.SetActive(false);
        PlayButton.SetActive(true);
        VideoArray[current].Pause();
     
    }
}
