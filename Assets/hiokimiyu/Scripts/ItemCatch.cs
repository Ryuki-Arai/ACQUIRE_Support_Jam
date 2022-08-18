using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemCatch : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _shurikentext;
    [SerializeField] TextMeshProUGUI _kunaitext;
    /// <summary>ƒNƒiƒC‚ÌŒ»İ‚Ì”</summary>
    int _kunai;
    /// <summary>è— Œ•‚ÌŒ»İ‚Ì”</summary>
    int _shuriken;
    void Start()
    {
        Kunai = 0;
        Shuriken = 0;
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
