using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoPlay : MonoBehaviour
{
    public GameObject Sphere;
    public GameObject Sphere2;
    public GameObject Camera;
    public Image Panel;
    public Image TempColor;
    public float count;
     MovieTexture video360 ;
    // Start is called before the first frame update
    void Start()
    {
       video360 = (MovieTexture)Sphere.GetComponent<Renderer>().material.mainTexture;
        video360.loop=true;
        video360.Play();

    }

    // Update is called once per frame
    void Update()
    {
        count -= 0.4f;
        Camera.transform.rotation=Quaternion.Euler(Camera.transform.rotation.x , Camera.transform.rotation.y + count ,transform.rotation.z );  
        if(Input.GetKeyDown(KeyCode.E)){
            video360.Stop();
            Camera.transform.position = Sphere2.transform.position;
            MovieTexture video360_2 = (MovieTexture)Sphere2.GetComponent<Renderer>().material.mainTexture;
            video360_2.loop=true;
            video360_2.Play();
          
        } 
        
    }

    Color GetRandomColor(){
        return new Color(Random.value, Random.value, Random.value);
    }
}
