using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private Animator _animator;
    private CharacterController _controller;
    private Rigidbody _rigidbody;
    private Vector3 pos;
    private bool isJump;
    // private int speed;

    private int idle = Animator.StringToHash("Idle");
    private int attack = Animator.StringToHash("Attack");

    private int vSpeed = Animator.StringToHash("VSpeed");
    private int hSpeed = Animator.StringToHash("HSpeed");
    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();//获取自身的角色控制器组件.
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
        // speed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (Input.GetMouseButtonDown(0))
        {
            _animator.SetTrigger(attack);
        }
        if (Input.GetMouseButtonUp(0))
        {
            _animator.SetTrigger(idle);
        }

        _animator.SetFloat(vSpeed,v);
        _animator.SetFloat(hSpeed,h);
        //
        // if (isJump)
        // {
        //     
        // }
        //
        _controller.Move(new Vector3(h, 0, v)*Time.deltaTime*3);
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector3.up*10,ForceMode.Impulse);
        }
    }
}
