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
    //[SerializeField] float _speed = 2; // �X�s�[�h�FInspector�Ŏw��

    //Rigidbody2D _rbody;

    //float _vx = 0;
    
    // �����܂�

    void Start()
    {
        //_rbody = GetComponent<Rigidbody2D>(); // �X�e�[�^�X�����̃X�N���v�g�Ȃ̂ŁA��ŏ���

        hitCount = HitCount.hit0;

        //_rbody.constraints = RigidbodyConstraints2D.FreezeRotation; // �X�e�[�^�X�����̃X�N���v�g�Ȃ̂ŁA��ŏ���
    }

    // ���̏�������ŏ���
    //void Update()
    //{
    //    _vx = 0;
        

    //    if (Input.GetKey("right")) // �E�L�[�������ꂽ��
    //    {
    //        _vx = _speed; // �E�ɐi�ވړ��ʂ�����
            
    //    }
    //    if (Input.GetKey("left")) // ���L�[�������ꂽ��
    //    {
    //        _vx = -_speed; // ���ɐi�ވړ��ʂ�����
            
    //    }
    //}

    // ���̏�������ŏ���
    //void FixedUpdate()
    //{
    //    _rbody.velocity = new Vector2(_vx, _rbody.velocity.y); // �ړ�����
    //}

    /// <summary>
    ///  �G���Q���ɓ����������̃��C�t�ω�
    /// </summary>
    /// <param name="col"></param>
    void OnCollisionEnter2D(Collision2D col)
    {
        // 1���
        if (col.gameObject.tag == "Enemy" && hitCount == HitCount.hit0)
        {
            _lifeImages[0].enabled = false;

            hitCount = HitCount.hit1;
        }
        // 2���
        else if (col.gameObject.tag == "Enemy" && hitCount == HitCount.hit1)
        {
            _lifeImages[1].enabled = false;

            hitCount = HitCount.hit2;
        }
        // 3���
        else if (col.gameObject.tag == "Enemy" && hitCount == HitCount.hit2)
        {
            _lifeImages[2].enabled = false;

            hitCount = HitCount.hit0;

        }
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
}
