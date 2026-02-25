using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportMaster2
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();

            if (guna2TextBox3 != null)
            {
                guna2TextBox3.PasswordChar = '*';
                guna2TextBox3.UseSystemPasswordChar = false;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string login = guna2TextBox1.Text.Trim();
            string psw = guna2TextBox3.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(psw))
            {
                MessageBox.Show("Введите логин и пароль", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UserManager.ValidateUser(login, psw))
            {
                MessageBox.Show("Добро пожаловать!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                var mainForm = new MainForm();
                mainForm.FormClosed += (s, args) => this.Close();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                guna2TextBox1.Text = "";
                guna2TextBox3.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Переход на форму регистрации
            this.Hide();
            var regForm = new Form1();
            regForm.FormClosed += (s, args) => this.Close();
            regForm.Show();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
