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

namespace finalprojectxz
{

    public partial class Form1 : Form
    {
        public string bd = "users.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string login = guna2TextBox1.Text;
            string psw = guna2TextBox2.Text;

            if (psw != guna2TextBox2.Text)
                MessageBox.Show("!!!");

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(psw))
            {
                MessageBox.Show("Ввелите логин или пароль");
                return;
            }
            if (CheckUser(login, psw))
            {
                this.Hide();
                //var newForm = new Form2();
                //newForm.FormClosed += (s, args) => this.Close();
                //newForm.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
                guna2TextBox1.Text = "";
                guna2TextBox2.Text = "";
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
            this.Hide();
            var newForm = new Form3();
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
        }
    }
}
