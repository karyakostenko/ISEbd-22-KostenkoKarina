using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsLocomotive
{
	/// <summary>
	/// Класс-коллекция парковок
	/// </summary>
	public class ParkingCollection
	{
		/// <summary>
		/// Словарь (хранилище) с парковками
		/// </summary>
		readonly Dictionary<string, Parking<Vehicle>> parkingStages;
		/// <summary>
		/// Возвращение списка названий парковок
		/// </summary>
		public List<string> Keys => parkingStages.Keys.ToList();
		/// <summary>
		/// Ширина окна отрисовки
		/// </summary>
		private readonly int pictureWidth;
		/// <summary>
		/// Высота окна отрисовки
		/// </summary>
		private readonly int pictureHeight;
		/// <summary>
		/// Разделитель для записи информации в файл
		/// </summary>
		private readonly char separator = ':';
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="pictureWidth"></param>
		/// <param name="pictureHeight"></param>
		public ParkingCollection(int pictureWidth, int pictureHeight)
		{
			parkingStages = new Dictionary<string, Parking<Vehicle>>();
			this.pictureWidth = pictureWidth;
			this.pictureHeight = pictureHeight;
		}
		/// <summary>
		/// Добавление парковки
		/// </summary>
		/// <param name="name">Название парковки</param>
		public void AddParking(string name)
		{
			if (parkingStages.ContainsKey(name))
			{
				return;
			}
			parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight));
		}
		/// <summary>
		/// Удаление парковки
		/// </summary>
		/// <param name="name">Название парковки</param>
		public void DelParking(string name)
		{
			if (parkingStages.ContainsKey(name))
			{
				parkingStages.Remove(name);
			}
		}
		/// <summary>
		/// Доступ к парковке
		/// </summary>
		/// <param name="ind"></param>
		/// <returns></returns>
		public Parking<Vehicle> this[string ind]
		{
			// Продумать логику для индексатора
			get
			{
				if (parkingStages.ContainsKey(ind))
				{
					return parkingStages[ind];
				}
				return null;
			}
		}
		/// <summary>
		/// Метод записи информации в файл
		/// </summary>
		/// <param name="text">Строка, которую следует записать</param>
		/// <param name="stream">Поток для записи</param>
		private void WriteToFile(string text, FileStream stream)
		{
			byte[] info = new UTF8Encoding(true).GetBytes(text);
			stream.Write(info, 0, info.Length);
		}
		
		public bool SaveData(string filename)
		{
			if (File.Exists(filename))
			{
				File.Delete(filename);
			}
			using (StreamWriter fs = new StreamWriter(filename, true, Encoding.UTF8))
			{
				fs.WriteLine("ParkingCollection");
				foreach (var level in parkingStages)
				{
					//Начинаем парковку
					fs.WriteLine($"Parking{separator}{level.Key}");
					ITransport locomotive = null;
					for (int i = 0; (locomotive = level.Value.GetNext(i)) != null; i++)
					{
						if (locomotive != null)
						{
							//если место не пустое
							//Записываем тип машины
							if (locomotive.GetType().Name == "Locomotive")
							{
								fs.Write($"Locomotive{separator}");
							}
							if (locomotive.GetType().Name == "Electrovoz")
							{
								fs.Write($"Electrovoz{separator}");
							}
							//Записываемые параметры
							fs.WriteLine(locomotive.ToString());
						}
					}
				}
			}
			return true;
		}

	

		public bool LoadData(string filename)
		{
			if (!File.Exists(filename))
			{
				return false;
			}
			using (StreamReader fs = new StreamReader(filename, Encoding.UTF8))
			{

				string data = fs.ReadLine();
				string key = string.Empty;

				if (data.Contains("ParkingCollection"))
				{
					//очищаем записи
					parkingStages.Clear();
				}
				else
				{
					//если нет такой записи, то это не те данные
					return false;
				}
				while ((data = fs.ReadLine()) != null)
				{
					Vehicle locomotive = null;

					if (data.Contains("Parking"))
					{
						//начинаем новую парковку
						key = data.Split(separator)[1];
						parkingStages.Add(key, new Parking<Vehicle>(pictureWidth, pictureHeight));
						continue;
					}
					if (string.IsNullOrEmpty(data))
					{
						continue;
					}
					if (data.Split(separator)[0] == "Locomotive")
					{
						locomotive = new Locomotive(data.Split(separator)[1]);
					}
					else if (data.Split(separator)[0] == "Electrovoz")
					{
						locomotive = new Electrovoz(data.Split(separator)[1]);
					}
					var result = parkingStages[key] + locomotive;
					if (!result)
					{
						return false;
					}

				}
			}
			return true;
		}



	}
}
