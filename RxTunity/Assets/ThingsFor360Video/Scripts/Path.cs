using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public Transform[] target;
    private float speed;
    public float velocity;

    private int current;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //move until you reach the current object/waypoint
        if(transform.position != target[current].position )
        {

            if(Input.GetKey(KeyCode.UpArrow)){
                speed=velocity;
            }else if(Input.GetKey(KeyCode.DownArrow)){
                speed=velocity* -1;
            }else speed=0;
            Vector3 pos = Vector3.MoveTowards(transform.position , target[current].position , speed*Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);    
            
            /*Vector3 origin =
            transform.right =  (transform - target[current].transform);       
            transform.LookAt(target[current].transform);*/
        } //object/waypoint reached, move to the next object 
        else current = ( current + 1) % target.Length;
    }
}
