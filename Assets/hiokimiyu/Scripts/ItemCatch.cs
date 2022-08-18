using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemCatch : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _shurikentext;
    [SerializeField] TextMeshProUGUI _kunaitext;
    /// <summary>�N�i�C�̌��݂̐�</summary>
    int _kunai;
    /// <summary>�藠���̌��݂̐�</summary>
    int _shuriken;
    void Start()
    {
        _shurikentext.text = "0";
        _kunaitext.text = "0";
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "kunai" && _kunai < 5)
        {
            _kunai++;
            _kunaitext.text = _kunai.ToString();
        }
        if(collision.tag == "shuriken" && _shuriken < 5)
        {
            _shuriken++;
            _shurikentext.text = _shuriken.ToString();
        }
    }
}
