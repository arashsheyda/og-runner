using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCharcaterController : MonoBehaviour
{
    private CharacterController _controller;

    [SerializeField] private LayerMask groundLayers;
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _jumpHeight = 2f;

    private float gravity = -77f;
    private Vector3 velocity;
    private bool isGrounded;
    private bool groundedPlayer;

    public Timer timer;

    public Joystick joystick;


    // Start is called before the first frame update
    void Start()
    {
        timer.GetComponent<Timer>().StartTimer();
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        isGrounded = _controller.isGrounded;

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = 0f;
        }

        _controller.Move(joystick.Direction * Time.deltaTime * _speed);

        // Endless Forward Run
        // _controller.Move(Vector3.forward * Time.deltaTime * _speed);

        float x = Input.GetAxis("Horizontal");
        Vector3 move = transform.right * x * Time.deltaTime * _speed;
        _controller.Move(move);

        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            velocity.y += Mathf.Sqrt(_jumpHeight * -3f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        _controller.Move(velocity * Time.deltaTime);

    }

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(1);
        timer.GetComponent<Timer>().PauseTimer();
    }

    public void Jump() {

        if (isGrounded)
        {
            velocity.y += Mathf.Sqrt(_jumpHeight * -3f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        _controller.Move(velocity * Time.deltaTime);
    }
}
