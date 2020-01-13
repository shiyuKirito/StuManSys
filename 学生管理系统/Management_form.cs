using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string str1 = Login_form.us;
            string str2 = Login_form.psw;
            Welcom_textbox.Text = "欢迎管理员: " +str1+"  登陆管理界面";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_form from1 = new Login_form();
            this.Visible = false;
            from1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void stumbutton_Click(object sender, EventArgs e)
        {
            student form3 = new student();
            this.Visible = false;
            form3.Show();
        }

        private void techmbutton_Click(object sender, EventArgs e)
        {

        }

        private void crbutton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 form4 = new Form4();
            form4.Show();
        }
        private void textbutton_Click(object sender, EventArgs e)
        {
            stutext1 form1=new stutext1();
            this.Visible = false;
            form1.Show();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否确认关闭？", "关闭", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            e.Cancel = result != DialogResult.Yes;
            base.OnClosing(e);
        }
    }
}
