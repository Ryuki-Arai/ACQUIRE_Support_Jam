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
    [SerializeField, Tooltip("手裏剣")] GameObject _shuriken;
    [SerializeField, Tooltip("クナイ")] GameObject _kunai;
    [SerializeField, Tooltip("発射位置")] Transform _mazzle;
    [SerializeField, Tooltip("斬撃エフェクト")] GameObject _effect;
    Animator _anim;
    [SerializeField] Mode _mode;

    public Mode Mode
    {
        get => _mode;
    }

    void Start()
    {
        _anim = GetComponent<Animator>();
    }
    void Update()
    {
        if(_effect)_effect.SetActive(Input.GetMouseButton(0));
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("斬");
            
        }
        else if (Input.GetMouseButtonDown(1) && ItemCatch.Instance.Kunai > 0 && _mode == Mode.kunai)
        {
            _anim.SetTrigger("Kunai");
            Instantiate(_kunai, _mazzle.position,Quaternion.identity);
            ItemCatch.Instance.Kunai--;
            
        }
        else if(Input.GetMouseButtonDown(1) && ItemCatch.Instance.Shuriken > 0 && _mode == Mode.shuriken)
        {
            if (_anim) _anim.SetTrigger("Shuriken");
            Instantiate(_shuriken, _mazzle.position, Quaternion.identity);
            ItemCatch.Instance.Shuriken--;
            
        }
        if (Input.GetMouseButtonDown(2))
        {
            _mode = _mode == Mode.shuriken ? Mode.kunai : Mode.shuriken;
            ItemCatch.Instance.ModeChange();
        }
    }
}
