using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    /// <summary>移動スピード</summary>
    [SerializeField] float _speed = 5f;
    /// <summary> ジャンプスピード</summary>
    [SerializeField] float _jump = 10f;
    /// <summary>ジャンプボタンを離した時の上昇減衰</summary>
    [SerializeField] float _gravityjump = 0.8f;
    float _h;
    /// <summary> 接地判定</summary>
    bool _isGround = default;
    bool _flipX = true;
    Rigidbody2D _rb;
    Animator _anim;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    void Update()
    {
        //_h = Input.GetAxis("Horizontal");
        //Vector2 velocity = _rb.velocity;

        //if(Input.GetButton("Horizontal"))
        //{
        //    //_rb.velocity = new Vector2(_speed * Time.deltaTime, _rb.velocity.y);
        //    transform.Translate(_speed * _h * Time.deltaTime, 0, 0);

        //}
        _h = Input.GetAxisRaw("Horizontal");
        Vector2 dir = new Vector2(_h, 0);
        var velocity = dir.normalized * _speed;
        velocity.y = _rb.velocity.y;
        _rb.velocity = velocity;

        if (_flipX)
        {
            FlipX(this._h);
        }

        if (Input.GetKeyDown(KeyCode.Space) && _isGround)
        {
            //_rb.AddForce(Vector2.up * _jump, ForceMode2D.Impulse);
            velocity.y = _jump;
            //_isGround = false;
        }
        else if (!Input.GetKey(KeyCode.Space) && velocity.y > 0)
        {
            velocity.y *= _gravityjump;
        }

        _rb.velocity = velocity;
    }

    private void LateUpdate()
    {
        if (_anim)
        {
            Vector2 walkSpeed = _rb.velocity;
            walkSpeed.y = 0;
            _anim.SetFloat("Walk", Mathf.Abs(walkSpeed.magnitude));
            _anim.SetBool("Jump", !_isGround);
        }
    }

    void FlipX(float horizontal)
    {
        if(horizontal > 0)
        {
            this.transform.localScale = new Vector3(Mathf.Abs(this.transform.localScale.x), this.transform.localScale.y, this.transform.localScale.z);
        }
        else if(horizontal < 0)
        {
            this.transform.localScale = new Vector3(-1 * Mathf.Abs(this.transform.localScale.x), this.transform.localScale.y, this.transform.localScale.z);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _isGround = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _isGround = false;
        }
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            _isGround = true;
        }
    }*/
    /*private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            _isGround = false;
        }
    }*/
}
