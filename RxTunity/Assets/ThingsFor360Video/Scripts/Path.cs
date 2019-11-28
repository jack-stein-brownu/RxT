using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Path : MonoBehaviour
{
    public Transform[] target;
    public VideoPlayer[] VideoArray;
    public GameObject[] cylinders;
    private float speed;
    public float velocity;
    
    public bool Forward;
    //public MeshPath[] MeshPathClass;

    private bool ItCanMove;

    private int current;
    // Start is called before the first frame update
    void Start()
    {
        //PauseButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {   //move until you reach the current object/waypoint
        
        if(transform.position != target[current].position )
        {
            Vector3 pos = Vector3.MoveTowards(transform.position , target[current].position , speed*Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
            RotateCylinder();

        } //object/waypoint reached, move to the next object 
        else speed=0; //current = ( current + 1) % target.Length;
        Debug.Log(current);

        if(Input.GetKey(KeyCode.E)){
            ButtonMoveForward();
            Forward=true;
        }
        if(Input.GetKey(KeyCode.Q)){
            ButtonMoveBackward();
            Forward=false;
        }
        
    }

    public void ButtonMoveForward(){
        current+=1;
        /*for(int i =0 ; i<= MeshPathClass.Length ; i++){
            MeshPathClass[i].Forward = true;
        }*/
        Forward=true;
        if(current < target.Length){
            speed=velocity;
            
        }else if(current>=target.Length){
            current=0;
            speed=velocity*1;
        }

    }

    public void ButtonMoveBackward(){
        current-=1;
        Forward=false;
       /* for(int i =0 ; i<= MeshPathClass.Length ; i++){
            MeshPathClass[i].Forward = false;
        }*/
        
        if(current >= 0){            
              speed=velocity*1;
        }else if(current<0){          
            current= target.Length-1;
            speed=velocity*1;
        }
    }

     public void ButtonPlay(){
        //PlayButton.SetActive(false);
        //PauseButton.SetActive(true);
        VideoArray[current].Play();
     
    }

     public void ButtonPause(){
        //PauseButton.SetActive(false);
        //PlayButton.SetActive(true);
        VideoArray[current].Pause();
     
    }
    public void RotateCylinder(){
        for(int i = 0; i<cylinders.Length; i++){
            cylinders[i].transform.Rotate(0, 10f*Time.deltaTime, 0, Space.Self);
        }
    }

    public void RockPathForward(){

    }
}
