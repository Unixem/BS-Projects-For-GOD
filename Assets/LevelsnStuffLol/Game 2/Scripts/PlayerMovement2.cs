using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float jumpHeight = 3f;
    
    Vector3 velocity;
    bool isGrounded;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        Vector3 move = transform.right * x + transform.forward * z;
        
        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Debug.Log("Jumpped");
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 20f;
        } else
        {
            speed = 12f;
        }

        velocity.y += gravity + Time.deltaTime;
        
        controller.Move(velocity * Time.deltaTime);
    }
}
