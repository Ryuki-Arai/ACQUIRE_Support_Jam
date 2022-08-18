using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
///  プレイヤーステータス
/// </summary>
public class PlayerStatus : MonoBehaviour
{
    [SerializeField, Header("当たった回数")] HitCount hitCount;

    [SerializeField, Header("ライフ")] Image[] _lifeImages;

    /// 後で消す
    [SerializeField] float _speed = 2; // スピード：Inspectorで指定

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
///  敵や障害物に当たった回数
/// </summary>
enum HitCount
{
    hit0,
    hit1,
    hit2,
    hit3,
}
