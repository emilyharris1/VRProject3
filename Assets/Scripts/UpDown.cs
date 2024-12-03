using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UpDown : MonoBehaviour
{
    public InputActionReference upButton;
    public InputActionReference downButton;
    public Transform player;
    public float movePower = 70f; 

    void Start()
    {
    }

    void Update() {
        if ((downButton.action.ReadValue<float>() > 0f) && (player.position.y > -15f)) {
            player.position += new Vector3(0f, -movePower * Time.deltaTime, 0f);
        } 
        
        if (upButton.action.ReadValue<float>() > 0f) {
            player.position += new Vector3(0f, movePower * Time.deltaTime, 0f);
        } 
    }

}
