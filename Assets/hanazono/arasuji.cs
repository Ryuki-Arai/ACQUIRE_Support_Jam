using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arasuji : MonoBehaviour
{
    [SerializeField] List<string> messageList = new List<string>();//会話文リスト
    [SerializeField] Text text;
    [SerializeField] float novelSpeed;//一文字一文字の表示する速さ
    int novelListIndex = 0; //現在表示中の会話文の配列
    bool t = false;//フラグ
    float time = 0;
    void Times1()
    {
        StartCoroutine(Novel());
    }
    void Start()
    {

        Invoke("Times1",4f);
        
    }

    void Times()
    {
        text.text += "\n\n";

        novelListIndex++; //次の会話文配列
        if (novelListIndex < messageList.Count)//全ての会話を表示したか
        {
            StartCoroutine(Novel());
        }
    }
 
    private IEnumerator Novel()
    {
        time += Time.deltaTime;
        
            int messageCount = 0; //現在表示中の文字数
            /* text.text = ""; //テキストのリセット*/
            while (messageList[novelListIndex].Length > messageCount)//文字をすべて表示していない場合ループ
            {
                text.text += messageList[novelListIndex][messageCount];//一文字追加
                messageCount++;//現在の文字数
                yield return new WaitForSeconds(novelSpeed);//任意の時間待つ
            }
            Invoke("Times", 1.5f);
            
        
        
    }
 /*   private void Update()
    {
        if (time == 6.0f)
        {
            t = true;
        }
    }*/
}