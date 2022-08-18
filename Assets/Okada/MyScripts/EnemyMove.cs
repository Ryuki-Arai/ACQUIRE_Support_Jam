using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMove : MonoBehaviour
{
    [SerializeField, Header("トリガーポイント")] Collider2D[] _triggerPoints; 
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col1)
    {
        col1 = _triggerPoints[0];
    }

    void OnTriggerExit2D(Collider2D col2)
    {
        col2 = _triggerPoints[1];
    }
}
