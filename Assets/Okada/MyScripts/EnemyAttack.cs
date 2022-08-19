using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyAttack : MonoBehaviour
{
    [SerializeField, Header("モーションアニメ")] Animator _animator;

    [SerializeField, Header("モーションアニメ")] Animator _animator2;

    [SerializeField] GameObject _zangekiObject;

    [SerializeField] float _spawnTime;
    
    void Start()
    {
        

        _animator = GetComponent<Animator>();

        _animator2 = GetComponent<Animator>();

        InvokeRepeating("AttackMotion", _spawnTime, _spawnTime);
    }

    
    void Update()
    {
        
    }

    void AttackMotion()
    {
        _zangekiObject.SetActive(true);

        _animator.SetBool("Attack", true);


        _animator2.Play("Zangeki(Boss)");
    }

    
}
