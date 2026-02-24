using Newtonsoft.Json;
using ReportMaster.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportMaster.Services
{
    /// <summary>
    /// Класс для управления данными (сохранение, загрузка, хранение)
    /// </summary>
    public class DataManager
    {
        // Путь к файлу с данными
        private string dataFilePath = Path.Combine(Application.LocalUserAppDataPath, "data.json");

        // Списки для хранения записей
        public List<FinanceRecord> Finances { get; set; }
        public List<TaskRecord> Tasks { get; set; }
        public List<EventRecord> Events { get; set; }

        public DataManager()
        {
            Finances = new List<FinanceRecord>();
            Tasks = new List<TaskRecord>();
            Events = new List<EventRecord>();
        }

        /// <summary>
        /// Сохранение данных в JSON файл
        /// </summary>
        public void SaveData()
        {
            try
            {
                // Создаем объект для сериализации
                var data = new
                {
                    Finances = this.Finances,
                    Tasks = this.Tasks,
                    Events = this.Events
                };

                // Сериализуем в JSON
                string json = JsonConvert.SerializeObject(data, Formatting.Indented);

                // Создаем папку, если её нет
                Directory.CreateDirectory(Path.GetDirectoryName(dataFilePath));

                // Сохраняем в файл
                File.WriteAllText(dataFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Загрузка данных из JSON файла
        /// </summary>
        public void LoadData()
        {
            try
            {
                // Проверяем, существует ли файл
                if (!File.Exists(dataFilePath))
                {
                    // Если нет - создаем тестовые данные для примера
                    CreateTestData();
                    return;
                }

                // Читаем JSON из файла
                string json = File.ReadAllText(dataFilePath);

                // Десериализуем
                var data = JsonConvert.DeserializeObject<dynamic>(json);

                // Заполняем списки
                Finances = JsonConvert.DeserializeObject<List<FinanceRecord>>(data.Finances.ToString());
                Tasks = JsonConvert.DeserializeObject<List<TaskRecord>>(data.Tasks.ToString());
                Events = JsonConvert.DeserializeObject<List<EventRecord>>(data.Events.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                CreateTestData();
            }
        }

        /// <summary>
        /// Создание тестовых данных для примера
        /// </summary>
        private void CreateTestData()
        {
            // Тестовые финансы
            Finances = new List<FinanceRecord>
            {
                new FinanceRecord { Id = 1, Title = "Айфон", Category = "Расход", Date = DateTime.Now, Amount = -89900 },
                new FinanceRecord { Id = 2, Title = "Зарплата", Category = "Доход", Date = DateTime.Now, Amount = 150000 }
            };

            // Тестовые задачи
            Tasks = new List<TaskRecord>
            {
                new TaskRecord { Id = 1, Title = "Отчёт", Category = "Работа", Date = DateTime.Now, Status = "В работе", DueDate = DateTime.Now.AddDays(5) },
                new TaskRecord { Id = 2, Title = "Хлеб", Category = "Дом", Date = DateTime.Now, Status = "Выполнено", DueDate = DateTime.Now }
            };

            // Тестовые события
            Events = new List<EventRecord>
            {
                new EventRecord { Id = 1, Title = "ДР Марины", Category = "Праздник", Date = DateTime.Now.AddDays(3), Place = "Ресторан", NeedRemind = true },
                new EventRecord { Id = 2, Title = "Собеседование", Category = "Работа", Date = DateTime.Now.AddDays(1), Place = "Онлайн", NeedRemind = false }
            };
        }

        /// <summary>
        /// Получение следующего ID для финансов
        /// </summary>
        public int GetNextFinanceId()
        {
            if (Finances.Count == 0) return 1;
            return Finances.Max(f => f.Id) + 1;
        }

        /// <summary>
        /// Получение следующего ID для задач
        /// </summary>
        public int GetNextTaskId()
        {
            if (Tasks.Count == 0) return 1;
            return Tasks.Max(t => t.Id) + 1;
        }

        /// <summary>
        /// Получение следующего ID для событий
        /// </summary>
        public int GetNextEventId()
        {
            if (Events.Count == 0) return 1;
            return Events.Max(e => e.Id) + 1;
        }
    }
}