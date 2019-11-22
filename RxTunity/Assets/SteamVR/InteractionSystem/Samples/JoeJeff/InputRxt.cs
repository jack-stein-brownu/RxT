using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class InputRxt : MonoBehaviour
{
    public SteamVR_Action_Vector2 moveAction = SteamVR_Input.GetAction<SteamVR_Action_Vector2>("platformer", "Move");
    private Vector3 movement;
    
    private Interactable interactable;
    private SteamVR_Input_Sources hand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //hand = interactable;
        Vector2 m = moveAction[hand].axis;
        movement = new Vector3(m.x, 0, m.y);
        //Debug.Log(movement);

        float rot = transform.eulerAngles.y;
        
    }
    public void Text()
    {
        Debug.Log("Click");
    }
}
