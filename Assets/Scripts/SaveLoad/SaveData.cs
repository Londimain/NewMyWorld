[System.Serializable] //Обязательно нужно указать, что класс должен сериализоваться
public class SaveData 
{
	//Создание полей с игровыми параметрами
	public float currHP;
	public float HP;
	public float currMP;
	public float MP;
	public float currXP;
	public float XP;
	public int level;
    public int currentAmmo;
    public int allAmmo;
    public int health;
	public float[] position; //В Unity позиция игрока записана с помощью класса Vector3, но его нельзя сериализовать. Чтобы обойти эту проблему, данные о позиции будут помещены в массив типа float.
    
	public SaveData(PlayerMovement character) //Конструктор класса
	{
		//Получение данных, которые нужно сохранить
		//HP = character.HP;
		//currHP = character.currHP;
		//MP = character.MP;
		//currMP = character.currMP;
		//XP = character.XP;
		//currXP = character.currXP;
		//level = character.level;
        //currentAmmo = character.currentAmmo;
        //allAmmo = character.allAmmo;
        health = character.health;

		position = new float[3] //Получение позиции
		{
			character.transform.position.x,
			character.transform.position.y,
			character.transform.position.z
		};
	}
}


