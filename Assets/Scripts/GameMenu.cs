using UnityEngine;

public class GameMenu : MonoBehaviour
{
    public GameObject menuUI; // ������ �� ������ UI ����
    private bool isPaused = false; //

    void Start()
    {
        // ���������, ��� ���� ������ ��� ������� ����
        menuUI.SetActive(false);
    }

    void Update()
    {
        // ��� ������� ������� Escape ����������/�������� ����
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleMenu();
        }
    }

    void ToggleMenu()
    {
        // ����������� ��������� ���������� ����
        menuUI.SetActive(!menuUI.activeSelf);
        isPaused = !isPaused; // ����������� ��������� �����

        // ������������ ��� ������������ ����� � ����������� �� ��������� �����
        if (isPaused)
        {
            Time.timeScale = 0; // ������������ �����
        }
        else
        {
            Time.timeScale = 1; // ������������ �����
        }

        // � ����������� �� ������ �������, �� ����� ������ ���������� ����� ��� ��������� ������ �������� ��� �������� ����
        // Time.timeScale = menuUI.activeSelf ? 0 : 1; // ������������/������������ ����� ��� ��������/�������� ����
    }
}
