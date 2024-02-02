using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{

    private Vector2 mouseSenitivity;
    [SerializeField]private float pitch, yInput, yaw, xInput, maxVerticalAngle;
    private float xRotation = 0f;

    public Transform playerBody;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        yInput = pitch * mouseSenitivity.y * Time.deltaTime;
        xInput = yaw * mouseSenitivity.x * Time.deltaTime;

        xRotation -= yInput;

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * xInput);
    }

    public void Look(InputAction.CallbackContext context)
    {
        pitch = context.ReadValue<Vector2>().y;
        yaw = context.ReadValue<Vector2>().x;
    }

}
