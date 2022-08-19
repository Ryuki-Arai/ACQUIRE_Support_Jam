using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenSquare : MonoBehaviour
{
    [SerializeField] string _changeScene;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            //SceneManager.LoadScene(_changeScene);
            FadeManager.Instance.LoadScene(_changeScene, 3.0f);
        }
    }
}
