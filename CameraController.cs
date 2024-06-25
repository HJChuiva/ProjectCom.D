using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float MoveSpeed = 10f; // 카메라 이동 속도

    void Update()
    {
        Vector3 move = new Vector3();

        // 카메라 이동을 위한 입력 처리
        if (Input.GetKey(KeyCode.W))
        {
            move.y += 1f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            move.y -= 1f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            move.x -= 1f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            move.x += 1f;
        }

        // 움직임 적용
        transform.position += move * MoveSpeed * Time.deltaTime;
    }
}