using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace ReportMaster2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Настройка скрытого ввода пароля
            if (guna2TextBox3 != null)
            {
                guna2TextBox3.PasswordChar = '*';
                guna2TextBox3.UseSystemPasswordChar = false;
            }

            if (guna2TextBox2 != null)
            {
                guna2TextBox2.PasswordChar = '*';
                guna2TextBox2.UseSystemPasswordChar = false;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string login = guna2TextBox1.Text.Trim();
            string psw = guna2TextBox3.Text;
            string confirmPsw = guna2TextBox2?.Text ?? "";

            // Проверка на пустые поля
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(psw))
            {
                MessageBox.Show("Заполните все поля", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка длины пароля
            if (psw.Length < 3)
            {
                MessageBox.Show("Пароль должен содержать минимум 3 символа", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка подтверждения пароля
            if (psw != confirmPsw)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка существования пользователя
            if (UserManager.UserExists(login))
            {
                MessageBox.Show("Такой логин уже занят", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Регистрация нового пользователя
            if (UserManager.RegisterUser(login, psw))
            {
                MessageBox.Show("Регистрация прошла успешно!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Переход на форму входа
                this.Hide();
                var loginForm = new Form3();
                loginForm.FormClosed += (s, args) => this.Close();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Ошибка при регистрации", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Переход на форму входа
            this.Hide();
            var loginForm = new Form3();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }
    }
}
