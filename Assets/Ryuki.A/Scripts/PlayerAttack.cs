using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Mode
{
    kunai,
    shuriken,
}

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public class PlayerAttack : MonoBehaviour
{
    [SerializeField, Tooltip("�藠��")] GameObject _shuriken;
    [SerializeField, Tooltip("�N�i�C")] GameObject _kunai;
    [SerializeField, Tooltip("���ˈʒu")] Transform _mazzle;
    [SerializeField, Tooltip("�a���G�t�F�N�g")] GameObject _effect;
    SpriteRenderer _sr;
    [SerializeField, Tooltip("�v���p�e�B�g�p")] ItemCatch _ic;
    Animator _anim;
    Mode _mode;

    public Mode Mode
    {
        get => _mode;
    }

    void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
        _ic.GetComponent<ItemCatch>();
        _mode = Mode.shuriken;
        _anim = GetComponent<Animator>();
    }
    void Update()
    {
        _effect.SetActive(Input.GetMouseButton(0));
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("�a");
            
        }
        else if (Input.GetMouseButtonDown(1) && _ic.Kunai > 0 && _mode == Mode.kunai)
        {
            Instantiate(_kunai, _mazzle.position,Quaternion.identity);
            _ic.Kunai--;
            
        }
        else if(Input.GetMouseButtonDown(1) && _ic.Shuriken > 0 && _mode == Mode.shuriken)
        {
            Instantiate(_shuriken, _mazzle.position, Quaternion.identity);
            _ic.Shuriken--;
            
        }
        if (Input.GetMouseButtonDown(2))
        {
            _mode = _mode == Mode.shuriken ? Mode.kunai : Mode.shuriken;
            _ic.Shuriken += 0;
            _ic.Kunai += 0;
        }
    }

    private void FixedUpdate()
    {
        if (_anim)
        {
            _anim.SetBool("Shuriken", Input.GetMouseButtonDown(0));
            _anim.SetBool("Kunai", Input.GetMouseButtonDown(1) && _mode == Mode.kunai);
            _anim.SetBool("Slash", Input.GetMouseButtonDown(1) && _mode == Mode.shuriken);
        }
    }
}
