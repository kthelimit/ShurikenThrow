using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenController : MonoBehaviour
{
    Vector3 startPos;
    float speed = 0;
    float attenuation = 0.96f;
    float rotateMutiply = 400f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //마우스를 클릭한 지점의 좌표를 가져온다
            startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            //마우스 클릭을 뗀 지점의 좌표를 가져와 두 지점간의 거리를 계산하고,
            //적당한 수로 나누어 속도로 변경한다.
            speed = (Input.mousePosition.y - startPos.y);
        }
        //위로 발사하기
        this.gameObject.transform.Translate(new Vector3(0, speed, 0) * Time.deltaTime, Space.World);
        //표창을 회전시키기
        this.gameObject.transform.Rotate(new Vector3(0, 0, speed * rotateMutiply) * Time.deltaTime);
        //감속
        speed *= attenuation;
    }
}
