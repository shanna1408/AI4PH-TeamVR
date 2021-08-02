using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ballController : MonoBehaviour
{
    public float speed = 0;

    private Rigidbody rb;

    private float movementX;
    private float movementY;
    private Vector3 resetPosition;

    // Start is called before the first frame update
    void Start()
    {
        resetPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        rb = GetComponent<Rigidbody>();
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    public void resetPositionButton()
    {
        rb.angularDrag =0;
        rb.angularVelocity = Vector3.zero;
        rb.velocity = Vector3.zero;
        rb.position = resetPosition;
    }

}
