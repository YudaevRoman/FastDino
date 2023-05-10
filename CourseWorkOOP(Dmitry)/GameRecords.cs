
namespace CourseWorkOOP_Dmitry_
{
    //Класс Рекордов Игры
    public class GameRecords
    {
        //Поля
        private bool isUpdate = false;

        //Подклассы
        [System.Serializable()]
        public class Record
        {
            //Свойства
            public string Name { get; }
            public int Score { get; }
            public DifficultyLevel Difficulty { get; }

            //Конструкторы
            public Record(
                string name, int score,
                DifficultyLevel difficulty)
            {
                Name = name;
                Score = score;
                Difficulty = difficulty;
            }
        }

        //Свойства
        public System.Collections.Generic.List<Record> Records { get; set; }
        public string FileName { get; set; } = "Records.rec";

        //Конструкторы
        public GameRecords()
        {
            Records = new System.Collections.Generic.List<Record>();
            Load();
        }
        //Внешние методы
        //Методы изменения
        public void AddRecord(Record record)
        {
            int index = Records.FindIndex(x =>
                 x.Difficulty.AccelerationDelay == record.Difficulty.AccelerationDelay &&
                 x.Difficulty.CurrentDifficulty == record.Difficulty.CurrentDifficulty &&
                 x.Difficulty.MaxSpawnDelay == record.Difficulty.MaxSpawnDelay &&
                 x.Difficulty.MinSpawnDelay == record.Difficulty.MinSpawnDelay &&
                 x.Name == record.Name);
            if (index >= 0)
            {
                if (Records[index].Score < record.Score)
                {
                    Records.RemoveAt(index);
                    Records.Add(record);
                    isUpdate = true;
                    Save();
                }
            }
            else
            {
                Records.Add(record);
                isUpdate = true;
                Save();
            }
        }
        public void DelRecord(Record record)
        {
            if (Records.Find(x =>
                 x.Difficulty.AccelerationDelay == record.Difficulty.AccelerationDelay &&
                 x.Difficulty.CurrentDifficulty == record.Difficulty.CurrentDifficulty &&
                 x.Difficulty.MaxSpawnDelay == record.Difficulty.MaxSpawnDelay &&
                 x.Difficulty.MinSpawnDelay == record.Difficulty.MinSpawnDelay &&
                 x.Name == record.Name &&
                 x.Score == record.Score) != null)
            {
                Records.Remove(record);
                isUpdate = true;
                Save();
            }
        }
        //Методы сортировки
        public void SortingByName() => Records.Sort(CompareByName);
        public void SortingByRecord() => Records.Sort(CompareByRecord);
        //Метод вывода рекордов
        public void OutputIn(System.Windows.Forms.DataGridView dGV)
        {
            dGV.RowCount = 0;
            foreach (Record record in Records)
                dGV.Rows.Add(
                    record.Name,
                    record.Score,
                    record.Difficulty.CurrentDifficulty.ToString()
                    );
        }

        //Внутренние мтоды
        private int CompareByName(Record record1, Record record2)
            => string.Compare(record1.Name, record2.Name);
        private int CompareByRecord(Record record1, Record record2)
            => string.Compare(
                    System.Convert.ToString(record1.Score), 
                    System.Convert.ToString(record2.Score)
                );
        //Метод сохранения рекордов в файл
        private void Save()
        {
            if (isUpdate)
            {
                try
                {
                    System.Runtime.Serialization.
                    Formatters.Binary.BinaryFormatter bf =
                    new System.Runtime.Serialization.
                    Formatters.Binary.BinaryFormatter();
                    using (System.IO.Stream writer =
                        new System.IO.FileStream(
                            FileName, System.IO.FileMode.Create))
                        bf.Serialize(writer, Records);
                    isUpdate = false;
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show(
                        "Ошибка операции сохра-\r\nнения рекордов",
                        "Ошибка",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
        }
        private void Load()
        {
            if (System.IO.File.Exists(FileName))
            {
                try
                {
                    System.Runtime.Serialization.
                    Formatters.Binary.BinaryFormatter bf =
                    new System.Runtime.Serialization.
                    Formatters.Binary.BinaryFormatter();
                    using (System.IO.Stream reader =
                        new System.IO.FileStream(
                            FileName, System.IO.FileMode.Open))
                        Records = (System.Collections.
                        Generic.List<Record>)bf.Deserialize(reader);
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show(
                        "Ошибка операции загру-\r\nзки рекордов." + 
                        "Файл бу-\r\nдет пересоздан при сле-\r\n" +
                        "дующей операции записи.",
                        "Ошибка",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error);
                    System.IO.File.Delete(FileName);
                }
            }
        }
    }
}