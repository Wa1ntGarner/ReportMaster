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
    public partial class EventForm : Form
    {
        // Свойство для получения результата
        public EventRecord EventRecord { get; private set; }

        // Режим редактирования
        private bool isEditMode = false;
        public EventForm()
        {
            InitializeComponent();

            // Устанавливаем сегодняшнюю дату
            dtpDate.Value = DateTime.Now;

            // Выбираем первую категорию
            if (cmbCategory.Items.Count > 0)
                cmbCategory.SelectedIndex = 0;
        }
        public EventForm(EventRecord recordToEdit) : this()
        {
            isEditMode = true;
            EventRecord = recordToEdit;

            // Заполняем поля
            txtTitle.Text = recordToEdit.Title;
            cmbCategory.SelectedItem = recordToEdit.Category;
            dtpDate.Value = recordToEdit.Date;
            txtPlace.Text = recordToEdit.Place;
            chkRemind.Checked = recordToEdit.NeedRemind;
            this.Text = "Редактирование события";
        }

        private void EventForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Проверяем заполнение
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Введите название события", "Ошибка",
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

            // Если редактируем - обновляем запись
            if (isEditMode && EventRecord != null)
            {
                EventRecord.Title = txtTitle.Text;
                EventRecord.Category = cmbCategory.SelectedItem.ToString();
                EventRecord.Date = dtpDate.Value;
                EventRecord.Place = txtPlace.Text;
                EventRecord.NeedRemind = chkRemind.Checked;
            }
            else
            {
                // Создаем новую запись
                EventRecord = new EventRecord
                {
                    Title = txtTitle.Text,
                    Category = cmbCategory.SelectedItem.ToString(),
                    Date = dtpDate.Value,
                    Place = txtPlace.Text,
                    NeedRemind = chkRemind.Checked
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
