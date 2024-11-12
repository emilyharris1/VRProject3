using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UpDown : MonoBehaviour
{
    public InputActionReference upButton;
    public InputActionReference downButton;
    public Transform player;
    public float movePower = 100f; 
    // public float movePowerDown = 0f;
    // public float movePowerUp = 0f;

    void Start()
    {
    }

    void Update() {
        if (downButton.action.ReadValue<float>() > 0f) {
            // if(movePowerDown<500f) {
            //     movePowerDown+=0.5f;
            // }
            player.position += new Vector3(0f, -movePower * Time.deltaTime, 0f);
        } 
        // else if(movePowerDown>= 0){
        //     movePowerDown-=15f;
        //     player.position += new Vector3(0f, -movePowerDown * Time.deltaTime, 0f);
        // }
        
        if (upButton.action.ReadValue<float>() > 0f) {
            // if(movePowerUp<500f) {
            //     movePowerUp+=0.5f;
            // }
            player.position += new Vector3(0f, movePower * Time.deltaTime, 0f);
        } 
        // else if(movePowerUp>= 0){
        //     movePowerUp-=15f;
        //     player.position += new Vector3(0f, movePowerUp * Time.deltaTime, 0f);
        // }
    }

}
