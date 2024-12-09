using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void Update()
    {
        GameObject[] creaturesLeft = GameObject.FindGameObjectsWithTag("Creatures");
        if (creaturesLeft.Length <= 1){
            SceneManager.LoadScene("WinScreen");
        }
    }
}
