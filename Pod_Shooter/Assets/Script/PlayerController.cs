using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    CharacterController characterController;
    // Use this for initialization
    void Start() {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update() {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        Vector3 mouvement = new Vector3(horizontal, 0, vertical);
        Vector3 ajustedMovement = transform.TransformDirection(mouvement);
        characterController.SimpleMove(ajustedMovement * Time.deltaTime * 500);
    }
}
