using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    InputManager inputManager;
    PlayerMotion playerMotion;
    CameraManager cameraManager;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        cameraManager = FindObjectOfType<CameraManager>();
        playerMotion = GetComponent<PlayerMotion>();
    }

    private void Update()
    {
        inputManager.HandleAllInputs();
        playerMotion.HandleAllMovement();
    }

    private void FixUpdate()
    {
        playerMotion.HandleAllMovement();
    }

    private void LateUpdate()
    {
        cameraManager.HandleAllCameraMovement();
    }
}
