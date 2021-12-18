using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsLocomotive
{
    class ParkingCollection
    {
        //Словарь (хранилище) с парковками
        readonly Dictionary<string, Parking<Vehicle>> parkingStages;
        //Возвращение списка названий парковок
        public List<string> Keys => parkingStages.Keys.ToList();
        //Ширина окна отрисовки
        private readonly int pictureWidth;
        //Высота окна отрисовки
        private readonly int pictureHeight;
        // Разделитель для записи информации в файл
        private readonly char separator = ':';

        public ParkingCollection(int pictureWidth, int pictureHeight) 
        {

            parkingStages = new Dictionary<string, Parking<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        
        }

        //Добавление парковки
        public void AddParking(string name) 
        {
            if (parkingStages.ContainsKey(name)) 
            {
                return;
            }

            parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight));   
        }

        public void DelParking(string name) 
        {
            if (parkingStages.ContainsKey(name)) 
            {
                parkingStages.Remove(name);
            }
        
        }

        public Parking<Vehicle> this[string ind] 
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                return null;
            }

        }

        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }

        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                WriteToFile($"ParkingCollection{Environment.NewLine}", fs);
                foreach (var level in parkingStages)
                {
                    //Начинаем парковку
                    WriteToFile($"Parking{separator}{level.Key}{Environment.NewLine}", fs);
                    foreach (ITransport locomotive in level.Value)
                    {
                        //Записываем тип мшаины
                        if (locomotive.GetType().Name == "Locomotive")
                        {
                            WriteToFile($"Locomotive{separator}", fs);
                        }
                        if (locomotive.GetType().Name == "Electrovoz")
                        {
                            WriteToFile($"Electrovoz{separator}", fs);
                        }
                        //Записываемые параметры
                        WriteToFile(locomotive + Environment.NewLine, fs);
                    }
                }
            }
        }
        //Доступ к парковке

        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                byte[] b = new byte[fs.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    bufferTextFromFile += temp.GetString(b);
                }
            }
            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("ParkingCollection"))
            {
                //очищаем записи
                parkingStages.Clear();
            }
            else
            {
                //если нет такой записи, то это не те данные
                throw new Exception("Неверный формат файла");
            }
            Vehicle locomotive = null;
            string key = string.Empty;
            for (int i = 1; i < strs.Length; ++i)
            {
                //идем по считанным записям
                if (strs[i].Contains("Parking"))
                {
                    //начинаем новую парковку
                    key = strs[i].Split(separator)[1];
                    parkingStages.Add(key, new Parking<Vehicle>(pictureWidth, pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(strs[i]))
                {
                    continue;
                }
                if (strs[i].Split(separator)[0] == "Locomotive")
                {
                    locomotive = new Locomotive(strs[i].Split(separator)[1]);
                }
                else if (strs[i].Split(separator)[0] == "Electrovoz")
                {
                    locomotive = new Electrovoz(strs[i].Split(separator)[1]);
                }
                if (!(parkingStages[key] + locomotive))
                {
                    throw new Exception("Не удалось загрузить локомотив на парковку");
                }
            }
        }
    }
}

    

