using UnityEngine;

using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class P1Movement : MonoBehaviour
{
    public float speed;
    public float jumpSpeed;
    public float gravity;
    public KeyCode jumpKey = KeyCode.Space;

    private CharacterController controller;
    private Vector3 velocity;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        bool isGrounded = controller.isGrounded;

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; 
        }

        float moveX = 0f;
        float moveZ = 0f;

        if (Input.GetKey(KeyCode.D)) moveZ += 1f;
        if (Input.GetKey(KeyCode.A)) moveZ -= 1f;

        Vector3 move = transform.forward * moveZ;
        move = move.normalized; 

        controller.Move(move * speed * Time.deltaTime);

       
        if (isGrounded && Input.GetKeyDown(jumpKey))
        {
            velocity.y = jumpSpeed;
        }

        velocity.y -= gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
