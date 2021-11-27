using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Animator animator;
    InputManager inputManager;
    PlayerMotion playerMotion;
    CameraManager cameraManager;

    public bool isInteracting;

    private void Awake()
    {
        animator = GetComponent<Animator>();
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
