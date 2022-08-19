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

       
    }

    
    void Update()
    {
        InvokeRepeating("AttackMotion", 0.5f, _spawnTime);
    }

    void AttackMotion()
    {
        _zangekiObject.SetActive(true);

        _animator2.Play("Zangeki(Boss)");

        _animator.SetBool("Attack", true);


        StartCoroutine("Back");
    }

    IEnumerator Back()
    {

        yield return new WaitForSeconds(1);

        _animator.SetBool("Attack", false);
    }

    
}
