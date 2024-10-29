using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class HumanController : MonoBehaviour
{
    private Animator _animator;
    private Vector2 _velocity;
    private bool _isMoving;

    void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            float rotation = Input.GetAxis("Mouse X");
            transform.Rotate(0, rotation, 0);
            Cursor.lockState = CursorLockMode.Locked;
        }
        else Cursor.lockState = CursorLockMode.None;


        _velocity.x = Input.GetAxis("Horizontal");
        _velocity.y = Input.GetAxis("Vertical");
        _isMoving = _velocity.magnitude > 0.01f;

        _velocity *= 1f + Input.GetAxis("Speed");

        if (Input.GetButtonUp("Jump")) _animator.SetTrigger("Jump");

        _animator.SetBool("IsMoving", _isMoving);
        _animator.SetFloat("Velocity X", _velocity.x);
        _animator.SetFloat("Velocity Y", _velocity.y);
    }
}
