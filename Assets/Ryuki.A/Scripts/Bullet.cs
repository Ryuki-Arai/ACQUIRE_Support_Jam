using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D _rb2d;
    [SerializeField, Tooltip("発射速度")] int _power;
    [SerializeField, Tooltip("消滅時間")] float deleteTime;

    // Start is called before the first frame update
    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        _rb2d.AddForce(Vector2.right * _power, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, deleteTime);
    }
}
