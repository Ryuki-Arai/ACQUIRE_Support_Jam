using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseControler : MonoBehaviour
{
    [SerializeField, Tooltip("�E�N���b�N����UI")] Image _mouseR;
    [SerializeField, Tooltip("���N���b�N����UI")] Image _mouseL;
    [SerializeField, Tooltip("�N���b�N���ĂȂ����̐F")] Color _colorF;
    [SerializeField, Tooltip("�N���b�N�������̐F")] Color _colorT;
    
    void Update()
    {
        if (Input.GetMouseButton(0))  _mouseL.color = _colorT;
        else _mouseL.color = _colorF;

        if (Input.GetMouseButton(1)) _mouseR.color = _colorT;
        else _mouseR.color = _colorF;
    }
}
