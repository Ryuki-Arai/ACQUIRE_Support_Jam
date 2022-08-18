using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D _rb2d;
    [SerializeField, Tooltip("���ˑ��x")] int _power;
    [SerializeField, Tooltip("���Ŏ���")] float deleteTime;

    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        _rb2d.AddForce(Vector2.right * _power, ForceMode2D.Impulse);
    }

    void Update()
    {
        Destroy(gameObject, deleteTime);
    }
}
