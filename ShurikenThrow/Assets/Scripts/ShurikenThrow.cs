using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShurikenThrow : MonoBehaviour
{
    [SerializeField]
    Transform shurikenPos;
    [SerializeField]
    Transform targetPos;
    [SerializeField]
    Text distanceText;

    void Start()
    {
        //ǥâ�� ��ǥ���� �Ÿ��� Ȯ���ϱ� ���� ���� ����
        shurikenPos = GameObject.Find("shurikenBlack").transform;
        targetPos = GameObject.Find("target").transform;
        //�Ÿ��� ǥ���ϱ� ���� �ؽ�Ʈ ������Ʈ ����
        distanceText = GameObject.Find("distance").GetComponent<Text>();
    }

    void Update()
    {
        //�ǽð����� ǥâ�� ��ǥ���� �Ÿ��� ������ ǥ���Ѵ�.
        float length = targetPos.position.y - shurikenPos.position.y;
        distanceText.text = "���� �Ÿ�\n" + length.ToString("0.00") + "m";
    }
}
