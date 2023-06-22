using UnityEngine;
using System.IO; //Библиотек для работы с файлами
using System.Runtime.Serialization.Formatters.Binary; //Библиотека для работы бинарной сериализацией

public static class SaveLoad //Создание статичного класса позволит использовать методы без объявления его экземпляров
{
	private static string path = Application.persistentDataPath + "/savelord.dat"; //Путь к сохранению. Вы можете использовать любое расширение
	//"/gamesave.skillbox"
    private static BinaryFormatter formatter = new BinaryFormatter(); //Создание сериализатора 
  
	public static void Save(PlayerMovement character) //Метод для сохранения
	{
		FileStream fs = new FileStream (path, FileMode.Create); //Создание файлового потока
		SaveData data = new SaveData(character); //Получение данных
		formatter.Serialize(fs, data); //Сериализация данных
		fs.Close(); //Закрытие потока
	}

	public static SaveData Load() //Метод загрузки
	{
		if(File.Exists(path)) { //Проверка существования файла сохранения
			FileStream fs = new FileStream(path, FileMode.Open); //Открытие потока
			SaveData data = formatter.Deserialize(fs) as SaveData; //Получение данных
			fs.Close(); //Закрытие потока
			return data; //Возвращение данных
		} 
		else 
		{
			return null; //Если файл не существует, будет возвращено null
		}
	}
}