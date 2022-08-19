using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public void TitleButton()
    {
        FadeManager.Instance.LoadScene("TitleScene", 1.0f);
    }

    public void ExitButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }

    public void arasujiButton()
    {
        FadeManager.Instance.LoadScene("arasuji", 3.0f);
    }
    public void PlayButton()
    {
        FadeManager.Instance.LoadScene("PlayScene", 3.0f);
    }
}
