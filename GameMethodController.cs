using UnityEngine;
using UnityEngine.UI;

public class GameMethodController : MonoBehaviour
{
    // �гΰ� ��ư�� ������ �� �ִ� ���� ����
    public GameObject gameMethodPanel;
    public Button gameMethodButton;
    public Button exitButton;

    void Start()
    {
        // ��ư Ŭ�� �̺�Ʈ�� �Լ� ���
        gameMethodButton.onClick.AddListener(ShowGameMethod);
        exitButton.onClick.AddListener(HideGameMethod);

        // �г��� �⺻������ ��Ȱ��ȭ
        gameMethodPanel.SetActive(false);
    }

    // ���� ��� �г��� ��Ÿ���� �Լ�
    void ShowGameMethod()
    {
        gameMethodPanel.SetActive(true);
    }

    // ���� ��� �г��� ����� �Լ�
    void HideGameMethod()
    {
        gameMethodPanel.SetActive(false);
    }
}
