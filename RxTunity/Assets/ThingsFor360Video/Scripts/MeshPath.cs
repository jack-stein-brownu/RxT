using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshPath : MonoBehaviour
{
    //public bool Forward;
    public Path ClassPath;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerEnter(Collider other)
    {   

        if(ClassPath.Forward){
            
            ClassPath.ButtonMoveForward();

        }else{

            ClassPath.ButtonMoveBackward();

        }

    }
    
}
