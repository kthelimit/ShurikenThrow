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
        //표창과 목표물의 거리를 확인하기 위한 변수 연결
        shurikenPos = GameObject.Find("shurikenBlack").transform;
        targetPos = GameObject.Find("target").transform;
        //거리를 표시하기 위한 텍스트 오브젝트 연결
        distanceText = GameObject.Find("distance").GetComponent<Text>();
    }

    void Update()
    {
        //실시간으로 표창과 목표물의 거리를 가져와 표시한다.
        float length = targetPos.position.y - shurikenPos.position.y;
        distanceText.text = "남은 거리\n" + length.ToString("0.00") + "m";
    }
}
