using System;
using TwoBitMachines.FlareEngine;
using TwoBitMachines.FlareEngine.AI;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = UnityEngine.Random;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;
    void Start ()
    {
        Application.targetFrameRate = 60;
    }

    void Update ()
    {
        // 스와이프의 길이를 구한다
        if(Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            // 마우스 버튼에서 손가락을 떼었을 때 좌표
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;

            // 스와이프 길이를 처음 속도로 변경한다
            speed = swipeLength / 500.0f;

            // 효과음을 재생한다
            GetComponent<AudioSource>().Play();
        }
        
        
        transform.Translate(speed,0,0);

        speed *= 0.98f; //감속
    }

}
