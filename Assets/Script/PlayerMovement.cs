using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    
    [SerializeField] float movementSpeed = 6f;
    [SerializeField] float jumpForce = 5f;
    
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;

    [SerializeField] AudioSource jumpSound;
    [SerializeField] Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.linearVelocity = new Vector3(horizontalInput * movementSpeed, rb.linearVelocity.y, verticalInput * movementSpeed);

        float horizontalSpeed = new Vector3(rb.linearVelocity.x, 0, rb.linearVelocity.z).magnitude;
        anim.SetFloat("Speed", horizontalSpeed);
        anim.SetBool("IsJumping", !IsGrounded());

        if (horizontalInput != 0 || verticalInput != 0)
        {
            transform.forward = new Vector3(rb.linearVelocity.x, 0, rb.linearVelocity.z);
        }

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            jumpSound.Play();
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, jumpForce, rb.linearVelocity.z);
        }
    }

    bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, 0.1f, ground);
    }
}