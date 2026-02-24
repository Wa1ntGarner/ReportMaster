using Guna.UI2.WinForms;
using ReportMaster.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportMaster2
{


    public partial class FinanceForm : Form
    {

        // Свойство, через которое получим результат
        public FinanceRecord FinanceRecord { get; private set; }

        // Режим редактирования или добавления
        private bool isEditMode = false;
        public FinanceForm()
        {
            InitializeComponent();

            // Устанавливаем сегодняшнюю дату по умолчанию
            dtpDate.Value = DateTime.Now;

            // Выбираем первую категорию по умолчанию
            if (cmbCategory.Items.Count > 0)
                cmbCategory.SelectedIndex = 0;
        }

        private void FinanceForm_Load(object sender, EventArgs e)
        {

        }


        public FinanceForm(FinanceRecord recordToEdit) : this()
        {
            isEditMode = true;
            FinanceRecord = recordToEdit;

            // Заполняем поля данными из записи
            txtTitle.Text = recordToEdit.Title;
            cmbCategory.SelectedItem = recordToEdit.Category;
            dtpDate.Value = recordToEdit.Date;
            txtAmount.Text = Math.Abs(recordToEdit.Amount).ToString(); // Показываем без знака
            this.Text = "Редактирование финансы";
        }

        // Ограничиваем ввод только цифр в поле суммы
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем цифры, backspace, запятую
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Разрешаем только одну запятую
            if (e.KeyChar == ',' && (sender as Guna2TextBox).Text.Contains(','))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            // Валидация
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Введите название", "Ошибка",
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

            decimal amount;
            if (!decimal.TryParse(txtAmount.Text, out amount))
            {
                MessageBox.Show("Введите корректную сумму", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
                return;
            }

            // Для расходов делаем сумму отрицательной
            if (cmbCategory.SelectedItem.ToString() == "Расход")
            {
                amount = -Math.Abs(amount);
            }
            else
            {
                amount = Math.Abs(amount);
            }

            // Если это редактирование - обновляем существующую запись
            if (isEditMode && FinanceRecord != null)
            {
                FinanceRecord.Title = txtTitle.Text;
                FinanceRecord.Category = cmbCategory.SelectedItem.ToString();
                FinanceRecord.Date = dtpDate.Value;
                FinanceRecord.Amount = amount;
            }
            else
            {
                // Создаем новую запись
                FinanceRecord = new FinanceRecord
                {
                    Title = txtTitle.Text,
                    Category = cmbCategory.SelectedItem.ToString(),
                    Date = dtpDate.Value,
                    Amount = amount
                };
            }

            // Закрываем форму с результатом OK
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
