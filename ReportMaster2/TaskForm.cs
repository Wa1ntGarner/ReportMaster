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

namespace ReportMaster2
{
    public partial class TaskForm : Form
    {

        // Свойство для получения результата
        public TaskRecord TaskRecord { get; private set; }

        // Режим редактирования
        private bool isEditMode = false;
        public TaskForm()
        {
            InitializeComponent();

            // Устанавливаем даты по умолчанию
            dtpDate.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now.AddDays(1);

            // Выбираем первую категорию
            if (cmbCategory.Items.Count > 0)
                cmbCategory.SelectedIndex = 0;

            // Выбираем первый статус
            if (cmbStatus.Items.Count > 0)
                cmbStatus.SelectedIndex = 0;
        }

        public TaskForm(TaskRecord recordToEdit) : this()
        {
            isEditMode = true;
            TaskRecord = recordToEdit;
            
            // Заполняем поля
            txtTitle.Text = recordToEdit.Title;
            cmbCategory.SelectedItem = recordToEdit.Category;
            dtpDate.Value = recordToEdit.Date;
            cmbStatus.SelectedItem = recordToEdit.Status;
            dtpDueDate.Value = recordToEdit.DueDate;
            this.Text = "Редактирование задачи";
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Проверяем заполнение
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Введите название задачи", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return;
            }

            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Выберите категорию", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Выберите статус", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем, что срок сдачи не раньше даты создания
            if (dtpDueDate.Value < dtpDate.Value)
            {
                MessageBox.Show("Срок сдачи не может быть раньше даты создания", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Если редактируем - обновляем запись
            if (isEditMode && TaskRecord != null)
            {
                TaskRecord.Title = txtTitle.Text;
                TaskRecord.Category = cmbCategory.SelectedItem.ToString();
                TaskRecord.Date = dtpDate.Value;
                TaskRecord.Status = cmbStatus.SelectedItem.ToString();
                TaskRecord.DueDate = dtpDueDate.Value;
            }
            else
            {
                // Создаем новую запись
                TaskRecord = new TaskRecord
                {
                    Title = txtTitle.Text,
                    Category = cmbCategory.SelectedItem.ToString(),
                    Date = dtpDate.Value,
                    Status = cmbStatus.SelectedItem.ToString(),
                    DueDate = dtpDueDate.Value
                };
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
