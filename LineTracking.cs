using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineTracking : MonoBehaviour
{
    LineRenderer lineRenderer;

    public Transform origin;
    public Transform direction;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
    }

    void Update()
    {
        lineRenderer.SetPosition(0, origin.position);
        lineRenderer.SetPosition(1, direction.position);
    }
}
