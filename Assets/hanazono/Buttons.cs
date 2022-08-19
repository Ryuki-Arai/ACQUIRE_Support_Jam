using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void TitleButton()
    {
        FadeManager.Instance.LoadScene("TitleScene", 1.0f);
    }
    public void TitleButton1()
    {
       SceneManager.LoadScene("TitleScene");
    }

    public void ExitButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }
    public void StaffButton()
    {
        FadeManager.Instance.LoadScene("StaffRoll", 3.0f);
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
