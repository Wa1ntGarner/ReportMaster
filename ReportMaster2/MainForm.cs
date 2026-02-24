using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using ReportMaster.Models;
using ReportMaster.Services;

namespace ReportMaster2
{
    public partial class MainForm : Form
    {
        private DataManager dataManager;
        private string currentFilter = "Все";

        public MainForm()
        {
            InitializeComponent();

            dataManager = new DataManager();
            dataManager.LoadData();
            RefreshAllTables();
            FillFilterComboBoxes();
        }

        /// <summary>
        /// Обновление всех таблиц
        /// </summary>
        private void RefreshAllTables()
        {
            RefreshFinancesTable();
            RefreshTasksTable();
            RefreshEventsTable();
        }

        /// <summary>
        /// Обновление таблицы финансов
        /// </summary>
        private void RefreshFinancesTable()
        {
            guna2DataGridView1.Rows.Clear();

            var filteredList = ApplyFinanceFilter();

            foreach (var finance in filteredList)
            {
                guna2DataGridView1.Rows.Add(
                    finance.Id,
                    finance.Title,
                    finance.Category,
                    finance.Date.ToString("dd.MM.yyyy"),
                    finance.Amount
                );
            }

            CalculateFinanceTotal(filteredList);
        }

        /// <summary>
        /// Обновление таблицы задач
        /// </summary>
        private void RefreshTasksTable()
        {
            try
            {
                dgvTasks.Rows.Clear();

                var filteredList = ApplyTaskFilter();

                foreach (var task in filteredList)
                {
                    dgvTasks.Rows.Add(
                        task.Id,
                        task.Title,
                        task.Category,
                        task.Date.ToString("dd.MM.yyyy"),
                        task.Status,
                        task.DueDate.ToString("dd.MM.yyyy")
                    );
                }

                CalculateTaskTotal(filteredList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка в RefreshTasksTable: {ex.Message}");
            }
        }

        /// <summary>
        /// Обновление таблицы событий
        /// </summary>
        private void RefreshEventsTable()
        {
            try
            {
                dgvEvents.Rows.Clear();

                var filteredList = ApplyEventFilter();

                foreach (var ev in filteredList)
                {
                    dgvEvents.Rows.Add(
                        ev.Id,
                        ev.Title,
                        ev.Category,
                        ev.Date.ToString("dd.MM.yyyy"),
                        ev.Place,
                        ev.NeedRemind ? "Да" : "Нет"
                    );
                }

                CalculateEventTotal(filteredList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка в RefreshEventsTable: {ex.Message}");
            }
        }

        /// <summary>
        /// Заполнение комбобоксов фильтрации
        /// </summary>
        private void FillFilterComboBoxes()
        {
            // Для финансов
            cmbFinanceFilter.Items.Clear();
            cmbFinanceFilter.Items.Add("Все");
            cmbFinanceFilter.Items.Add("Доход");
            cmbFinanceFilter.Items.Add("Расход");
            cmbFinanceFilter.SelectedIndex = 0;

            // Для задач
            cmbTaskFilter.Items.Clear();
            cmbTaskFilter.Items.Add("Все");
            cmbTaskFilter.Items.Add("В работе");
            cmbTaskFilter.Items.Add("Выполнено");
            cmbTaskFilter.Items.Add("Отложено");
            cmbTaskFilter.SelectedIndex = 0;

            // Для событий
            UpdateEventFilterCategories();
        }


        private void UpdateEventFilterCategories()
        {
            cmbEventFilter.Items.Clear();
            cmbEventFilter.Items.Add("Все");

            // Получаем все уникальные категории из списка событий
            var categories = dataManager.Events
                .Select(e => e.Category)
                .Distinct()
                .OrderBy(c => c)
                .ToList();

            foreach (var cat in categories)
            {
                if (!string.IsNullOrEmpty(cat))
                    cmbEventFilter.Items.Add(cat);
            }

            cmbEventFilter.SelectedIndex = 0;
        }

        /// <summary>
        /// Применение фильтра к финансам
        /// </summary>
        private List<FinanceRecord> ApplyFinanceFilter()
        {
            if (cmbFinanceFilter.SelectedItem == null || cmbFinanceFilter.SelectedItem.ToString() == "Все")
                return dataManager.Finances;

            string filter = cmbFinanceFilter.SelectedItem.ToString();
            return dataManager.Finances.Where(f => f.Category == filter).ToList();
        }

        /// <summary>
        /// Применение фильтра к задачам
        /// </summary>
        private List<TaskRecord> ApplyTaskFilter()
        {
            if (cmbTaskFilter.SelectedItem == null || cmbTaskFilter.SelectedItem.ToString() == "Все")
                return dataManager.Tasks;

            string filter = cmbTaskFilter.SelectedItem.ToString();
            return dataManager.Tasks.Where(t => t.Status == filter).ToList();
        }

        /// <summary>
        /// Применение фильтра к событиям
        /// </summary>
        private List<EventRecord> ApplyEventFilter()
        {
            if (cmbEventFilter.SelectedItem == null || cmbEventFilter.SelectedItem.ToString() == "Все")
                return dataManager.Events;

            string filter = cmbEventFilter.SelectedItem.ToString();
            return dataManager.Events.Where(e => e.Category == filter).ToList();
        }

        /// <summary>
        /// Подсчет итога по финансам
        /// </summary>
        private void CalculateFinanceTotal(List<FinanceRecord> finances)
        {
            decimal total = finances.Sum(f => f.Amount);
            lblFinanceTotal.Text = $"Итог: {total:N2} ₽";

            // Меняем цвет в зависимости от суммы
            if (total >= 0)
                lblFinanceTotal.ForeColor = System.Drawing.Color.Green;
            else
                lblFinanceTotal.ForeColor = System.Drawing.Color.Red;
        }

        /// <summary>
        /// Подсчет статистики по задачам
        /// </summary>
        private void CalculateTaskTotal(List<TaskRecord> tasks)
        {
            int total = tasks.Count;
            int completed = tasks.Count(t => t.Status == "Выполнено");
            int inProgress = tasks.Count(t => t.Status == "В работе");

            lblTaskTotal.Text = $"Всего: {total} | Выполнено: {completed} | В работе: {inProgress}";
        }

        /// <summary>
        /// Подсчет статистики по событиям
        /// </summary>
        private void CalculateEventTotal(List<EventRecord> events)
        {
            int total = events.Count;
            int withRemind = events.Count(e => e.NeedRemind);

            lblEventTotal.Text = $"Всего: {total} | С напоминанием: {withRemind}";
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что кликнули не на заголовок
            if (e.RowIndex < 0) return;

            // Получаем ID из первой колонки
            int id = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value);

            // Находим запись в списке
            var record = dataManager.Finances.FirstOrDefault(f => f.Id == id);

            if (record != null)
            {
                // Открываем форму редактирования
                FinanceForm financeForm = new FinanceForm(record);
                if (financeForm.ShowDialog() == DialogResult.OK)
                {
                    // Сохраняем изменения
                    dataManager.SaveData();

                    // Обновляем таблицу
                    RefreshFinancesTable();
                }
            }
        }

        private void cmbFinanceFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFinancesTable();
        }

        private void cmbTaskFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTasksTable();
        }

        private void btnFinanceExport_Click(object sender, EventArgs e)
        {
            ExportToCsv(ApplyFinanceFilter(), "Финансы");
        }

        private void btnTaskExport_Click(object sender, EventArgs e)
        {
            ExportToCsv(ApplyTaskFilter(), "Задачи");
        }

        private void btnEventExport_Click(object sender, EventArgs e)
        {
            ExportToCsv(ApplyEventFilter(), "События");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Определяем текущую вкладку
            string currentTab = guna2TabControl1.SelectedTab.Text;

            switch (currentTab)
            {
                case "Финансы":
                    FinanceForm financeForm = new FinanceForm();
                    if (financeForm.ShowDialog() == DialogResult.OK)
                    {
                        if (financeForm.FinanceRecord != null)
                        {
                            financeForm.FinanceRecord.Id = dataManager.GetNextFinanceId();
                            dataManager.Finances.Add(financeForm.FinanceRecord);
                            dataManager.SaveData();
                            RefreshFinancesTable();
                        }
                    }
                    break;

                case "Задачи":
                    TaskForm taskForm = new TaskForm();
                    if (taskForm.ShowDialog() == DialogResult.OK)
                    {
                        if (taskForm.TaskRecord != null)
                        {
                            taskForm.TaskRecord.Id = dataManager.GetNextTaskId();
                            dataManager.Tasks.Add(taskForm.TaskRecord);
                            dataManager.SaveData();
                            RefreshTasksTable();
                        }
                    }
                    break;

                case "События":
                    EventForm eventForm = new EventForm();
                    if (eventForm.ShowDialog() == DialogResult.OK)
                    {
                        if (eventForm.EventRecord != null)
                        {
                            eventForm.EventRecord.Id = dataManager.GetNextEventId();
                            dataManager.Events.Add(eventForm.EventRecord);
                            dataManager.SaveData();
                            RefreshEventsTable();
                            UpdateEventFilterCategories();
                        }
                    }
                    break;
            }
        }

        /// <summary>
        /// Экспорт данных в CSV файл
        /// </summary>
        private void ExportToCsv<T>(List<T> records, string typeName)
        {
            if (records.Count == 0)
            {
                MessageBox.Show("Нет данных для экспорта", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Диалог сохранения файла
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveDialog.FileName = $"ReportMaster_{typeName}_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveDialog.FileName, false,
                        System.Text.Encoding.UTF8))
                    {
                        // Получаем свойства объекта для заголовков
                        var properties = typeof(T).GetProperties();

                        // Записываем заголовки
                        string header = string.Join(";", properties.Select(p => p.Name));
                        sw.WriteLine(header);

                        // Записываем данные
                        foreach (var record in records)
                        {
                            var values = properties.Select(p => p.GetValue(record)?.ToString() ?? "");
                            string line = string.Join(";", values);
                            sw.WriteLine(line);
                        }
                    }

                    MessageBox.Show("Экспорт завершен успешно!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при экспорте: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataManager.SaveData();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataManager.SaveData();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void guna2DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            // Проверяем, нажата ли клавиша Delete
            if (e.KeyCode == Keys.Delete)
            {
                // Проверяем, выбрана ли какая-нибудь строка в таблице
                if (guna2DataGridView1.CurrentRow == null) return;

                // Получаем ID из первой колонки выбранной строки
                // cells[0] - это первая колонка (ID), Value - значение в ячейке
                int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value);

                // Спрашиваем пользователя, точно ли удалить
                DialogResult result = MessageBox.Show(
                    "Удалить запись?",           // Текст сообщения
                    "Подтверждение",              // Заголовок окна
                    MessageBoxButtons.YesNo,      // Кнопки Да/Нет
                    MessageBoxIcon.Question       // Иконка вопроса
                );

                // Если пользователь нажал "Да"
                if (result == DialogResult.Yes)
                {
                    // Ищем запись с таким ID в списке финансов
                    var record = dataManager.Finances.FirstOrDefault(f => f.Id == id);

                    // Если запись найдена
                    if (record != null)
                    {
                        // Удаляем её из списка
                        dataManager.Finances.Remove(record);

                        // Сохраняем изменения в файл
                        dataManager.SaveData();

                        // Обновляем таблицу на экране (перерисовываем)
                        RefreshFinancesTable();
                    }
                }
            }
        }

        private void Удалить(object sender, EventArgs e)
        {
            // Определяем, какая таблица сейчас активна
            DataGridView currentGrid = null;
            string typeName = "";

            if (guna2TabControl1.SelectedTab.Text == "Финансы")
            {
                currentGrid = guna2DataGridView1;
                typeName = "финансовую запись";
            }
            else if (guna2TabControl1.SelectedTab.Text == "Задачи")
            {
                currentGrid = dgvTasks;
                typeName = "задачу";
            }
            else if (guna2TabControl1.SelectedTab.Text == "События")
            {
                currentGrid = dgvEvents;
                typeName = "событие";
            }

            if (currentGrid == null || currentGrid.CurrentRow == null) return;

            // Получаем ID
            int id = Convert.ToInt32(currentGrid.CurrentRow.Cells[0].Value);

            // Подтверждение
            if (MessageBox.Show($"Удалить {typeName}?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Удаляем из соответствующего списка
                if (currentGrid == guna2DataGridView1)
                {
                    var record = dataManager.Finances.FirstOrDefault(f => f.Id == id);
                    if (record != null)
                    {
                        dataManager.Finances.Remove(record);
                    }
                }
                else if (currentGrid == dgvTasks)
                {
                    var record = dataManager.Tasks.FirstOrDefault(t => t.Id == id);
                    if (record != null)
                    {
                        dataManager.Tasks.Remove(record);
                    }
                }
                else if (currentGrid == dgvEvents)
                {
                    var record = dataManager.Events.FirstOrDefault(ev => ev.Id == id);
                    if (record != null)
                    {
                        dataManager.Events.Remove(record);
                    }
                }

                // Сохраняем и обновляем
                dataManager.SaveData();

                // Обновляем соответствующую таблицу
                if (currentGrid == guna2DataGridView1)
                    RefreshFinancesTable();
                else if (currentGrid == dgvTasks)
                    RefreshTasksTable();
                else if (currentGrid == dgvEvents)
                    RefreshEventsTable();
            }
        }

        private void dgvTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(dgvTasks.Rows[e.RowIndex].Cells[0].Value);
            var record = dataManager.Tasks.FirstOrDefault(t => t.Id == id);

            if (record != null)
            {
                TaskForm taskForm = new TaskForm(record);
                if (taskForm.ShowDialog() == DialogResult.OK)
                {
                    dataManager.SaveData();
                    RefreshTasksTable();
                }
            }
        }

        private void dgvEvents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(dgvEvents.Rows[e.RowIndex].Cells[0].Value);
            var record = dataManager.Events.FirstOrDefault(ev => ev.Id == id);

            if (record != null)
            {
                EventForm eventForm = new EventForm(record);
                if (eventForm.ShowDialog() == DialogResult.OK)
                {
                    dataManager.SaveData();
                    RefreshEventsTable();
                    UpdateEventFilterCategories();
                }
            }
        }

        private void dgvTasks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dgvTasks.CurrentRow == null) return;

                int id = Convert.ToInt32(dgvTasks.CurrentRow.Cells[0].Value);

                DialogResult result = MessageBox.Show("Удалить задачу?", "Подтверждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var record = dataManager.Tasks.FirstOrDefault(t => t.Id == id);
                    if (record != null)
                    {
                        dataManager.Tasks.Remove(record);
                        dataManager.SaveData();
                        RefreshTasksTable();
                    }
                }
            }
        }

        private void dgvEvents_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dgvEvents.CurrentRow == null) return;

                int id = Convert.ToInt32(dgvEvents.CurrentRow.Cells[0].Value);

                DialogResult result = MessageBox.Show("Удалить событие?", "Подтверждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var record = dataManager.Events.FirstOrDefault(ev => ev.Id == id);
                    if (record != null)
                    {
                        dataManager.Events.Remove(record);
                        dataManager.SaveData();
                        RefreshEventsTable();
                    }
                }
            }
        }

        private void cmbEventFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshEventsTable();
        }

        private void cmbEventFilter_KeyDown(object sender, KeyEventArgs e)
        {
            UpdateEventFilterCategories();
        }
    }
}
