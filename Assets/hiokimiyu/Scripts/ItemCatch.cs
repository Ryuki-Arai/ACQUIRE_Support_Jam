using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemCatch : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _shurikentext;
    [SerializeField] TextMeshProUGUI _kunaitext;
    [SerializeField,Tooltip("�藠���̏�����")] int _shiriInit;
    [SerializeField,Tooltip("�N�i�C�̏�����")] int _kunaiInit;
    /// <summary>�N�i�C�̌��݂̐�</summary>
    int _kunai;
    /// <summary>�藠���̌��݂̐�</summary>
    int _shuriken;
    void Start()
    {
        Kunai = _kunaiInit;
        Shuriken = _shiriInit;
        _kunaitext.text = Kunai.ToString();
        _shurikentext.text = Shuriken.ToString();
    }
    public int Kunai
    {
        get
        {
            return _kunai;
        }
        set
        {
            _kunai = value;
            _kunaitext.text = Kunai.ToString();
        }
    }
    public int Shuriken
    {
        get
        {
            return _shuriken;
        }
        set
        {
            _shuriken = value;
            _shurikentext.text = Shuriken.ToString();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "kunai" && Kunai < 5)
        {
            Kunai++;
            Destroy(collision.gameObject);
            _kunaitext.text = Kunai.ToString();
        }
        if(collision.tag == "shuriken" && Shuriken < 5)
        {
            Shuriken++;
            Destroy(collision.gameObject);
            _shurikentext.text = Shuriken.ToString();
        }
    }
}
