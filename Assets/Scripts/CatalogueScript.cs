using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Audio;

public class CatalogueScript : MonoBehaviour
{
    public InputActionReference openCatalogue;
    public GameObject catalogue;
    public GameObject mainCamera;
    // public LayerMask CreatureMask;
    private bool catStatus = false;
    public float offset_amount = 100f;
    // public InputActionReference triggerButtonPress;
    public AudioClip creatureSplash;

    void Start()
    {
        // triggerButtonPress.action.performed += DoRaycast;
        openCatalogue.action.performed += ToggleCatalogue;
        catalogue.SetActive(true);
        // GameObject.Find("/CatGameObject/Clownfish").GetComponent<MeshRenderer>().enabled = true;
    }

    void ToggleCatalogue(InputAction.CallbackContext __){
        catalogue.transform.position = mainCamera.transform.position;
        catalogue.transform.position += new Vector3(mainCamera.transform.forward.x, 0.0f, mainCamera.transform.forward.z).normalized * offset_amount;
        catalogue.transform.LookAt(mainCamera.transform);

        catStatus = !catStatus;
        // catalogue.SetActive(catStatus);
        if (!catStatus) {
            catalogue.transform.position = new Vector3(1000,-1000,1000);
        }
    }

    void OnTriggerEnter(Collider creature) {
        UnityEngine.Debug.Log("hit");
        if (creature.gameObject.layer == 3){
            GameObject.Find("/CatGameObject/" + creature.gameObject.name).GetComponent<MeshRenderer>().enabled = true;
            Destroy(creature.gameObject);
            GetComponent<AudioSource>().PlayOneShot(creatureSplash);
        }
    }
}
