using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {
    CharacterController characterController;
    // Use this for initialization
    void Start() {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update() {
        if (isLocalPlayer)
        {
            ProcessMovementInput();
        }
            
    }

    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();
        Camera cam = GetComponentInChildren<Camera>();
        if (isLocalPlayer)
        {
            cam.enabled = true;
        }
    }
    void ProcessMovementInput()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        Vector3 mouvement = new Vector3(horizontal, 0, vertical);
        Vector3 ajustedMovement = transform.TransformDirection(mouvement);
        characterController.SimpleMove(ajustedMovement * Time.deltaTime * 500);
    }
}
