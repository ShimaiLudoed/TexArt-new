using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    [SerializeField] private PlayerShooter player;
    private void Update()
    {
        ReadShootInput();
    }
    private void ReadShootInput()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log(player._bullka);
            player.Shoot();
        }
    }
}
