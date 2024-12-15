using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameOver : MonoBehaviour
{
    public AudioClip winAudio;
    public bool playedWin = false;

    void Update()
    {
        GameObject[] creaturesLeft = GameObject.FindGameObjectsWithTag("Creatures");
        // UnityEngine.Debug.Log(creaturesLeft.Length);
        if (creaturesLeft.Length < 1 && !playedWin){
            playedWin = true;
            StartCoroutine(winScreen());
        }
    }

    IEnumerator winScreen() {
        yield return new WaitForSeconds(2);
        GetComponent<AudioSource>().PlayOneShot(winAudio);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("WinScreen1");
    }
}
