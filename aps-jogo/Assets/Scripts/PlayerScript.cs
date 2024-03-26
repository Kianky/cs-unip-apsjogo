using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    PlayerMove move;

    private void Start()
    {
        move = GetComponent<PlayerMove>();
    }
}
