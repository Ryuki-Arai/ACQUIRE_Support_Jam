using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
 
    void Update()
    {
        
    }
    public void OnClickStartButton()
    {
        FadeManager.Instance.LoadScene("TitleScene", 1.0f);
    }
}
