using TMPro;
using TwoBitMachines.UIElement.Editor;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;
    

    void Start()
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance");
    }

    void Update()
    {
        float length = flag.transform.position.x - car.transform.position.x;
        if(length >= 0)
        distance.GetComponent<TextMeshProUGUI>().text = "거리: " + length.ToString("F2") + "m";
        else
        distance.GetComponent<TextMeshProUGUI>().text = "GameOver";
    }
}
