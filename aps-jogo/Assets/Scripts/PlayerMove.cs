using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    PlayerScript player;

    [SerializeField] FixedJoystick joystick;
    [SerializeField] float speed;
    Vector3 move;
    void Start()
    {
        player = GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        move = joystick.Direction;
        transform.position += move * speed * Time.deltaTime;
    }
}
