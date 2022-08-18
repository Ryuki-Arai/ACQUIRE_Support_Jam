using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D _rb2d;
    [SerializeField, Tooltip("発射速度")] int _power;
    [SerializeField, Tooltip("消滅時間")] float deleteTime;
    int vec;

    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        var h = Input.GetAxis("Horizontal");
        vec = GameObject.FindGameObjectWithTag("Player").transform.localScale.x > 0 ? 1 : -1;
        _rb2d.AddForce(Vector2.right * _power * vec, ForceMode2D.Impulse);
    }

    void Update()
    {
        Destroy(gameObject, deleteTime);
    }
}
