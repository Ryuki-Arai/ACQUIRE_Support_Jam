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

    // Start is called before the first frame update
    void Start()
    {
        _effect.SetActive(false);
    }

    // Update is called once per frame
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
            Debug.Log("��");
        }
    }
}
