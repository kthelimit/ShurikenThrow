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
            //���콺�� Ŭ���� ������ ��ǥ�� �����´�
            startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            //���콺 Ŭ���� �� ������ ��ǥ�� ������ �� �������� �Ÿ��� ����ϰ�,
            //������ ���� ������ �ӵ��� �����Ѵ�.
            speed = (Input.mousePosition.y - startPos.y);
        }
        //���� �߻��ϱ�
        this.gameObject.transform.Translate(new Vector3(0, speed, 0) * Time.deltaTime, Space.World);
        //ǥâ�� ȸ����Ű��
        this.gameObject.transform.Rotate(new Vector3(0, 0, speed * rotateMutiply) * Time.deltaTime);
        //����
        speed *= attenuation;
    }
}
