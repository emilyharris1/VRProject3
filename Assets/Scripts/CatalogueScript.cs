using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CatalogueScript : MonoBehaviour
{
    public InputActionReference openCatalogue;
    public GameObject catalogue;
    public GameObject mainCamera;
    public LayerMask CreatureMask;
    private bool catStatus = false;
    public float offset_amount = 100f;
    public InputActionReference triggerButtonPress;

    void Start()
    {
        triggerButtonPress.action.performed += DoRaycast;
        openCatalogue.action.performed += ToggleCatalogue;
        catalogue.SetActive(true);
        // GameObject.Find("/CatGameObject/Clownfish").GetComponent<MeshRenderer>().enabled = true;
    }

    void DoRaycast(InputAction.CallbackContext _){
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, CreatureMask)){
            GameObject.Find("/CatGameObject/" + hit.transform.gameObject.name).GetComponent<MeshRenderer>().enabled = true;
            Destroy(hit.transform.gameObject);
        }

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
}
