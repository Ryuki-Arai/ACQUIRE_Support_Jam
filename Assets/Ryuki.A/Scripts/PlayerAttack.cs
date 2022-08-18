using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public class PlayerAttack : MonoBehaviour
{
    [SerializeField, Tooltip("���˂���e")] GameObject _bullet;
    [SerializeField, Tooltip("���ˈʒu")] Transform _mazzle;
    [SerializeField, Tooltip("�a���G�t�F�N�g")] GameObject _effect;
    SpriteRenderer _sr;
    [SerializeField, Tooltip("�v���p�e�B�g�p")] ItemCatch _ic;

    void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
        _ic.GetComponent<ItemCatch>();
    }
    void Update()
    {
        _effect.SetActive(Input.GetMouseButton(0));
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("�a");
        }
        else if (Input.GetMouseButtonDown(1))
        {
            Instantiate(_bullet, _mazzle.position,Quaternion.identity);
            _ic.Kunai--;
            Debug.Log("��");
        }
    }
}
