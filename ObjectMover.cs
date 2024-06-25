using System.Collections;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    public float MoveDistance = 3f;
    public float MoveSpeed = 1f;
    public float RotateSpeed = 100f;

    public void MoveForward()
    {
        StartCoroutine(MoveOverTime(Vector3.forward * MoveDistance));
    }

    public void MoveBackward()
    {
        StartCoroutine(MoveOverTime(Vector3.back * MoveDistance));
    }

    public void MoveLeft()
    {
        StartCoroutine(MoveOverTime(Vector3.left * MoveDistance));
    }

    public void MoveRight()
    {
        StartCoroutine(MoveOverTime(Vector3.right * MoveDistance));
    }

    public void Spin()
    {
        StartCoroutine(RotateOverTime());
    }

    private IEnumerator MoveOverTime(Vector3 direction)
    {
        Vector3 startPosition = transform.position;
        Vector3 endPosition = startPosition + direction;
        float elapsedTime = 0f;
        float journeyTime = MoveDistance / MoveSpeed;

        while (elapsedTime < journeyTime)
        {
            transform.position = Vector3.Lerp(startPosition, endPosition, elapsedTime / journeyTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = endPosition;
    }
    private IEnumerator RotateOverTime()
    { 

        float elapsedTime = 0f;
        float journeyTime = MoveDistance / MoveSpeed;

        while (elapsedTime < journeyTime)
        {
            transform.Rotate(new Vector3(0, RotateSpeed * Time.deltaTime, 0));
            elapsedTime += Time.deltaTime;
            yield return null;
        }


    }
}