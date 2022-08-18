using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
///  �v���C���[�X�e�[�^�X
/// </summary>
public class PlayerStatus : MonoBehaviour
{
    [SerializeField, Header("����������")] HitCount hitCount;

    [SerializeField, Header("���C�t")] Image[] _lifeImages;

    /// ��ŏ���
    [SerializeField] float _speed = 2; // �X�s�[�h�FInspector�Ŏw��

    Rigidbody2D _rbody;

    void Start()
    {
        _rbody = GetComponent<Rigidbody2D>();

        hitCount = HitCount.hit0;

        _rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    
    void Update()
    {
        
    }


}

/// <summary>
///  �G���Q���ɓ���������
/// </summary>
enum HitCount
{
    hit0,
    hit1,
    hit2,
    hit3,
}
