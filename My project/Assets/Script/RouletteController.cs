using System;
using TwoBitMachines.FlareEngine;
using TwoBitMachines.FlareEngine.AI;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = UnityEngine.Random;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // 회전 속도
    
    
    void Start ()
    {
        
        Application.targetFrameRate = 60;
    }

    void Update ()
    {
        // 클릭하면 회전속도를 설정한다
        if(Input.GetMouseButtonDown(0))
        {
            rotSpeed = Random.Range(10,20);
        }
        
        // 회전 속도만큼 룰렛을 회전시킨다
        transform.Rotate(0,0,rotSpeed);

        // 룰렛을 감속시킨다
        rotSpeed *= 0.96f;
    }

}
