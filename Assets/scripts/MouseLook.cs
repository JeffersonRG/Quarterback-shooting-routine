using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{

    [SerializeField]private Vector2 mouseSenitivity;
    [SerializeField]private float pitch, yaw, maxVerticalAngle;
    private float yInput, xInput;
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
        xRotation -= ClampVerticalAngle(xRotation);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0f);
        Debug.Log(xRotation);
    }

    public void OnLook(InputValue context)
    {
        pitch = context.Get<Vector2>().y;
        yaw = context.Get<Vector2>().x;
    }

    private float ClampVerticalAngle(float angle)
    {
        return Mathf.Clamp(angle, -maxVerticalAngle, maxVerticalAngle);
    }
}
