using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    internal PlayerMove move;

    private void Start()
    {
        move = GetComponent<PlayerMove>();
    }
}
