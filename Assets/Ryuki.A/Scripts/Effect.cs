using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    [SerializeField, Tooltip("è¡ñ≈éûä‘")] float deleteTime;
    
    void Update()
    {
        Destroy(gameObject, deleteTime);
    }
}
