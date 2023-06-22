using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    public int health = 3;

	//Load and Save
	public void LoadCharacter()
	{
		SaveData data = SaveLoad.Load(); //Получение данных

		if(!data.Equals(null)) //Если данные есть
		{
			health = data.health;
			transform.position = new Vector3(data.position[0], data.position[1], data.position[2]);
		}
	}
	public void SaveCharacter()
	{
		SaveLoad.Save(this);
	}
}    
