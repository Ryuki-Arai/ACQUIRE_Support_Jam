using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arasuji : MonoBehaviour
{
    [SerializeField] List<string> messageList = new List<string>();//��b�����X�g
    [SerializeField] Text text;
    [SerializeField] float novelSpeed;//�ꕶ���ꕶ���̕\�����鑬��
    int novelListIndex = 0; //���ݕ\�����̉�b���̔z��
    bool t = false;//�t���O
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

        novelListIndex++; //���̉�b���z��
        if (novelListIndex < messageList.Count)//�S�Ẳ�b��\��������
        {
            StartCoroutine(Novel());
        }
    }
 
    private IEnumerator Novel()
    {
        time += Time.deltaTime;
        
            int messageCount = 0; //���ݕ\�����̕�����
            /* text.text = ""; //�e�L�X�g�̃��Z�b�g*/
            while (messageList[novelListIndex].Length > messageCount)//���������ׂĕ\�����Ă��Ȃ��ꍇ���[�v
            {
                text.text += messageList[novelListIndex][messageCount];//�ꕶ���ǉ�
                messageCount++;//���݂̕�����
                yield return new WaitForSeconds(novelSpeed);//�C�ӂ̎��ԑ҂�
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