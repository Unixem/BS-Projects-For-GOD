using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerToo1 : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;

    private float movementX;
    private float movementY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movement = movementValue.Get<Vector2>();
        
        movementX = movement.x;
        movementY = movement.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(movementX + 1);
        Vector3 movement = new Vector3(movementX, 0, movementY);
        rb.AddForce(movement * speed);
    }
}
