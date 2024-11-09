using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController characterController;
    public Vector2 input;
    public Vector3 direction;
    public float speed;
    public void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ApplyMovement();
    }
    public void ApplyMovement()
    {

       // var targetSpeed = isSpriting && sprintSlider.value > 0f ? speed * sprintMultiplier : speed;
        //currentSpeed = Mathf.MoveTowards(currentSpeed, targetSpeed, acceleration * Time.deltaTime);
        characterController.Move(direction * speed * Time.deltaTime);
       

    }

    public void Move(InputAction.CallbackContext context)
    {
        input = context.ReadValue<Vector2>();
        direction = new Vector3(input.x, 0.0f, input.y);
    }

}
