using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
    public GameObject menuUI; // Ссылка на объект UI меню
    private bool isPaused = false; //

    void Start()
    {
        // Убедитесь, что меню скрыто при запуске игры
        menuUI.SetActive(false);
    }

    void Update()
    {
        // При нажатии клавиши Escape показываем/скрываем меню
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleMenu();
        }
    }

    void ToggleMenu()
    {
        // Инвертируем состояние активности меню
        menuUI.SetActive(!menuUI.activeSelf);
        isPaused = !isPaused; // Инвертируем состояние паузы

        // Замораживаем или возобновляем время в зависимости от состояния паузы
        if (isPaused)
        {
            Time.timeScale = 0; // Замораживаем время
        }
        else
        {
            Time.timeScale = 1; // Возобновляем время
        }

        // В зависимости от вашего дизайна, вы также можете заморозить время или выполнить другие действия при открытии меню
        // Time.timeScale = menuUI.activeSelf ? 0 : 1; // Замораживаем/возобновляем время при открытии/закрытии меню
    }
}
