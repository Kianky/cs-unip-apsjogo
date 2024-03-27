using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Direcao { CIMA, BAIXO, ESQUERDA, DIREITA}
public class PlayerMove : MonoBehaviour
{
    PlayerScript player;

    [SerializeField] FixedJoystick joystick;
    [SerializeField] float speed;
    [SerializeField] internal bool estaParado;
    [SerializeField] Direcao direcao;
    Vector3 move;
    void Start()
    {
        player = GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(joystick.Direction.magnitude != 0)
        {
            estaParado = false;
            TrocarDirecao();
        }
        else 
        { 
            estaParado = true; 
        }
    }

    private void FixedUpdate()
    {
        move = joystick.Direction;
        transform.position += move * speed * Time.deltaTime;
    }

    public float GetVelocidade
    {
        get { return move.magnitude; }
    }
    public Direcao GetDirecao
    {
        get { return direcao; }
    }

    void TrocarDirecao()
    {
        if (Mathf.Abs(joystick.Horizontal) >= Mathf.Abs(joystick.Vertical))
        {
            if (joystick.Horizontal >= 0.01f) 
            {
                direcao = Direcao.DIREITA; 
            }
            else if (joystick.Horizontal <= -0.01f)
            {
                direcao = Direcao.ESQUERDA;
            }
        }
        if (Mathf.Abs(joystick.Vertical) >= Mathf.Abs(joystick.Horizontal))
        {
            if (joystick.Vertical >= 0.01f) 
            {
                direcao = Direcao.CIMA; 
            }
            else if (joystick.Vertical <= -0.01f)
            {
                direcao = Direcao.BAIXO;
            }
        }
    }
}
