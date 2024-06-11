// David Smolenaars 30072352
// 11 May 2024
// ToggleWarpMenuScript

// This script is responisble for togging the warp menu when f1 is pressed.
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ToggleWarpMenuScipt : MonoBehaviour
{
    [SerializeField] private GameObject parentObject;
    [SerializeField] private MonoBehaviour cameraMoveScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // will activate and deactivate the parent object when f1 is pressed, which in this case is the menu and its children.
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (parentObject != null)
            {
                parentObject.SetActive(!parentObject.activeSelf);

                if (parentObject.activeSelf) // when the user can select items from the menu
                {
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                    cameraMoveScript.enabled = false;
                }
                else
                {
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.Locked;
                    cameraMoveScript.enabled = true;
                }
            }
        }
    }
}
