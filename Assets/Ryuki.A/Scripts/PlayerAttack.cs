using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public class PlayerAttack : MonoBehaviour
{
    [SerializeField, Tooltip("発射する弾")] GameObject _bullet;
    [SerializeField, Tooltip("発射位置")] Transform _mazzle;
    [SerializeField, Tooltip("斬撃エフェクト")] GameObject _effect;
    
    void Update()
    {
        _effect.SetActive(Input.GetMouseButton(0));
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("斬");
        }
        else if (Input.GetMouseButtonDown(1))
        {
            Instantiate(_bullet, _mazzle.position,Quaternion.identity);
            Debug.Log("撃");
        }
    }
}
