using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float killHeight = -1f;
    private PlayerInputs inputs;
    private InputAction move;

    private void Awake()
    {
        inputs = new PlayerInputs();
        inputs.Enable();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //private void StartTouch()
    //{
    //    Debug.Log("Touch me");
    //}

    private void OnEnable()
    {
        move = inputs.Player.Move;
        move.Enable();
    }

    private void OnDisable()
    {
        move.Disable();
    }

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //if (Input.GetKey("d"))
        //{
        //    rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        //}
        //if (Input.GetKey("a"))
        //{
        //    rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        //}

        //if (rb.position.y < killHeight)
        //{
        //    FindObjectOfType<GameManager>().EndGame();
        //}
        Vector2 moveDirection = move.ReadValue<Vector2>();
        
        if (moveDirection != Vector2.zero)
            rb.AddForce(moveDirection.x * sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    
        if (rb.position.y < killHeight)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
