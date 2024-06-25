using UnityEngine;
using UnityEngine.UI;

public class GameMethodController : MonoBehaviour
{
    // 패널과 버튼을 참조할 수 있는 변수 선언
    public GameObject gameMethodPanel;
    public Button gameMethodButton;
    public Button exitButton;

    void Start()
    {
        // 버튼 클릭 이벤트에 함수 등록
        gameMethodButton.onClick.AddListener(ShowGameMethod);
        exitButton.onClick.AddListener(HideGameMethod);

        // 패널을 기본적으로 비활성화
        gameMethodPanel.SetActive(false);
    }

    // 게임 방법 패널을 나타내는 함수
    void ShowGameMethod()
    {
        gameMethodPanel.SetActive(true);
    }

    // 게임 방법 패널을 숨기는 함수
    void HideGameMethod()
    {
        gameMethodPanel.SetActive(false);
    }
}
