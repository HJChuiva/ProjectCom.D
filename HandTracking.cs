using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTracking : MonoBehaviour
{
    public UDPReceive udpRecive;
    public GameObject[] handPoints;


    void Update()
    {
        string data = udpRecive.data;

        data = data.Remove(0, 1);
        data = data.Remove(data.Length - 1, 1);
        print(data);
        string[] points = data.Split(',');
        print(points[0]);

        for (int i = 0; i < 21; i++)
        {
            float x = 5 - float.Parse(points[i * 3]) / 100;
            float y = float.Parse(points[i * 3 + 1]) / 100;
            float z = float.Parse(points[i * 3 + 2]) / 100;

            handPoints[i].transform.localPosition = new Vector3(x, y, z);
        }
    }
}