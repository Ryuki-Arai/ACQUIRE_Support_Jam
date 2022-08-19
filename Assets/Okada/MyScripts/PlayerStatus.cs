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

    [SerializeField, Tooltip("ゲームオーバーシーン")] string _gameScene;

    bool _isDead;

    /// 後で消す
    //[SerializeField] float _speed = 2; // スピード：Inspectorで指定

    //Rigidbody2D _rbody;

    //float _vx = 0;

    // ここまで

    void Start()
    {
        //_rbody = GetComponent<Rigidbody2D>(); // ステータスだけのスクリプトなので、後で消す

        hitCount = HitCount.hit0;
        _isDead = false;
        //_rbody.constraints = RigidbodyConstraints2D.FreezeRotation; // ステータスだけのスクリプトなので、後で消す
    }

    // この処理も後で消す
    //void Update()
    //{
    //    _vx = 0;


    //    if (Input.GetKey("right")) // 右キーが押されたら
    //    {
    //        _vx = _speed; // 右に進む移動量を入れる

    //    }
    //    if (Input.GetKey("left")) // 左キーが押されたら
    //    {
    //        _vx = -_speed; // 左に進む移動量を入れる

    //    }
    //}

    // この処理も後で消す
    //void FixedUpdate()
    //{
    //    _rbody.velocity = new Vector2(_vx, _rbody.velocity.y); // 移動処理
    //}

    /// <summary>
    ///  敵や障害物に当たった時のライフ変化
    /// </summary>
    /// <param name="col"></param>
    void OnCollisionEnter2D(Collision2D col)
    {
        // 1回目
        if (col.gameObject.tag == "Enemy" && hitCount == HitCount.hit0 && !_isDead)
        {
            _lifeImages[0].enabled = false;

            hitCount = HitCount.hit1;
        }
        // 2回目
        else if (col.gameObject.tag == "Enemy" && hitCount == HitCount.hit1 && !_isDead)
        {
            _lifeImages[1].enabled = false;

            hitCount = HitCount.hit2;
        }
        // 3回目
        else if (col.gameObject.tag == "Enemy" && hitCount == HitCount.hit2 && !_isDead)
        {
            _lifeImages[2].enabled = false;

            hitCount = HitCount.hit0;

            _isDead = true;
        }
        else if (col.gameObject.tag == "Enemy" && hitCount == HitCount.hit0 && _isDead)
        {
            FadeManager.Instance.LoadScene(_gameScene, 3.0f);
        }
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
}
