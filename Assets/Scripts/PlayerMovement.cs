using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [Header("Objects")]
    private CharacterController characterController;
    private Camera camera;

    [Header("Movement")]
    private Vector2 input;
    private Vector3 direction;
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;

    public Button button;
    public IntercomController intercom;
    
    public void Awake()
    {
        characterController = GetComponent<CharacterController>();
        camera = Camera.main;
        intercom = FindAnyObjectByType<IntercomController>();
    }
    void Update()
    {

        ApplyRotation();
        ApplyMovement();
    }
    public void ApplyMovement() => characterController.Move(direction * speed * Time.deltaTime);

    public void ApplyRotation()
    {
        direction = Quaternion.Euler(0.0f, camera.transform.eulerAngles.y, 0.0f) * new Vector3(input.x, 0.0f, input.y);
        var targetRotation = Quaternion.LookRotation(direction, Vector3.up);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }

    public void Move(InputAction.CallbackContext context)
    {
        input = context.ReadValue<Vector2>();
        direction = new Vector3(input.x, 0.0f, input.y);
    }

    public void Select(InputAction.CallbackContext context)
    {
        if (button == null) return;
        if (context.performed)
        {
            if (button.box.hasPlayed) return;
            intercom.UpdateIntercom(button.clip, button.box);
            button.box.hasPlayed = true;
        }
    }
}
