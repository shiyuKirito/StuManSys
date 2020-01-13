using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Login_form : Form
    {
        public static string us;
        public static string psw;
        public Login_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text;
            string str2 = textBox2.Text;
            string str3=null;
            string str = " ";
            Login login = new Login();
            //bool flag = true;
            try
            {
                login.Conn1(str1, str2);
                us = login.Userid;
                psw = login.Password;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Form2 form2 = new Form2();
            this.Visible = false;
            form2.Show();
            login.conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否确认关闭？", "关闭", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            e.Cancel = result != DialogResult.Yes;
            base.OnClosing(e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
