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

namespace finalprojectxz
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }
        
        private void Registr(string login, string psw,int value20)
        {
            value20 = 0;
            File.AppendAllText(bd, $"\n{login}|{psw}|{value20}");
        }
        int value20 = 0;
        private bool UserExist(string login)
        {
            if (!File.Exists(bd)) return false;

            string[] users = File.ReadAllLines(bd);
            foreach (string user in users)
            {
                string[] p = user.Split('|');
                if (p[0] == login) return true;
            }
            return false;
        }
        private bool CheckUser(string login, string psw)
        {
            if (!File.Exists(bd)) return false;

            string[] users = File.ReadAllLines(bd);
            foreach (string user in users)
            {
                string[] p = user.Split('|');
                if (p[0] == login)
                {
                    return p[1] == psw;
                }
            }
            return false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string login = guna2TextBox1.Text;
            string psw = guna2TextBox3.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(psw))
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }
            if (UserExist(login))
            {
                MessageBox.Show("Такой логин уже занят");
                guna2TextBox1.Text = "";
                guna2TextBox3.Text = "";
                return;
            }
            else
            {
                Registr(login, psw, value20);
                MessageBox.Show("Вы успешно зарегистрировались");
                this.Hide();
                //var newForm = new Form2();
                //newForm.FormClosed += (s, args) => this.Close();
                //newForm.Show();
            }
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
                MessageBox.Show("Успешный вход!", "Добро пожаловать",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                var newForm = new MainMenu();
                newForm.FormClosed += (s, args) => this.Close();
                newForm.Show();
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
            this.Hide();
            var newForm = new Form3();
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
