using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseControler : MonoBehaviour
{
    [SerializeField, Tooltip("右クリック判定UI")] Image _mouseR;
    [SerializeField, Tooltip("左クリック判定UI")] Image _mouseL;
    [SerializeField, Tooltip("クリックしてない時の色")] Color _colorF;
    [SerializeField, Tooltip("クリックした時の色")] Color _colorT;
    
    void Update()
    {
        if (Input.GetMouseButton(0))  _mouseL.color = _colorT;
        else _mouseL.color = _colorF;

        if (Input.GetMouseButton(1)) _mouseR.color = _colorT;
        else _mouseR.color = _colorF;
    }
}
