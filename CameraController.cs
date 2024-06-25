using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float MoveSpeed = 10f; // ī�޶� �̵� �ӵ�

    void Update()
    {
        Vector3 move = new Vector3();

        // ī�޶� �̵��� ���� �Է� ó��
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

        // ������ ����
        transform.position += move * MoveSpeed * Time.deltaTime;
    }
}