using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{
	[Header("Camear Variables")]
	private Vector2 input;
	private float cameraRotationX;
	private float cameraRotationY;

	[Header("Camera Settings")]
	[SerializeField] float sensitivityX = 8;
	[SerializeField] float sensitivityY = 0.5f;
	[Space(20)]
	[SerializeField] float cameraAngleMax;
	[SerializeField] float cameraAngleMin;


	// Start is called before the first frame update
	public void Look(InputAction.CallbackContext context)
	{
		input = context.ReadValue<Vector2>();
	}

	private void Update()
	{
		cameraRotationX += input.y * sensitivityY * -1 * Time.deltaTime; // up
		cameraRotationY += input.x * sensitivityX  * Time.deltaTime; // side
		cameraRotationX = Mathf.Clamp(cameraRotationX, cameraAngleMin, cameraAngleMax);
	}

	private void LateUpdate()
	{
		transform.eulerAngles = new Vector3(cameraRotationX, cameraRotationY, 0.0f);
		//transform.position = target.position - transform.forward * _distanceToPlayer;
	}
}
