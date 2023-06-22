using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour
{
    public GameObject MenuPanel;//указать отключонное меню пауза
    public void MenuPauseON()//открыть меню паузы
	{
		MenuPanel.SetActive(true);
		Time.timeScale = 0f;//остоновить время на сцене
	}
public void MenuPauseOFF()//закрыть меню паузы
	{
		MenuPanel.SetActive(false);
		Time.timeScale = 1f;//востоновить время на сцене
	}

    public void Exitgame()//выход из игры
    {
        Application.Quit();
        Debug.Log("Выход");
    }
}


