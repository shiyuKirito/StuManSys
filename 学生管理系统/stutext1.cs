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
    public partial class stutext1 : Form
    {
        public stutext1()
        {
            InitializeComponent();
            Login login = new Login();
            login.Conn1(Login_form.us, Login_form.psw);
            SqlCommand Sqcm = login.conn.CreateCommand();
            //int intID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            //SqlConnection Sqlcon;
            SqlDataAdapter Sqlda = new SqlDataAdapter("Select * from stutext ", login.conn);
            DataSet DS = new DataSet();
            Sqlda.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.Show();
            login.conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Visible = false;
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Conn1(Login_form.us, Login_form.psw);
            string str = "Select 学号 ,姓名 ,成绩, 科目 from stutext where 学号 like  '" + textBox1.Text+"%'";
            MessageBox.Show(str);
            SqlCommand Sqcm = login.conn.CreateCommand();
            SqlDataAdapter Sqlda = new SqlDataAdapter(str, login.conn);
            DataSet DS = new DataSet();
            Sqlda.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.Show();
            login.conn.Close();
        }//查询学号，支持模糊查询
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Conn1(Login_form.us, Login_form.psw);
            string str = "Select 科目,学号 ,姓名 ,成绩 from stutext where 科目 like  '" + textBox2.Text + "%'";
            //MessageBox.Show(str);
            SqlCommand Sqcm = login.conn.CreateCommand();
            SqlDataAdapter Sqlda = new SqlDataAdapter(str, login.conn);
            DataSet DS = new DataSet();
            Sqlda.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.Show();
            login.conn.Close();
        }//查询科目，支持模糊查询

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Conn1(Login_form.us, Login_form.psw);
            SqlCommand Sqcm = login.conn.CreateCommand();
            //int intID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            //SqlConnection Sqlcon;
            SqlDataAdapter Sqlda = new SqlDataAdapter("Select * from stutext ", login.conn);
            DataSet DS = new DataSet();
            Sqlda.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.Show();
            login.conn.Close();
        }//显示所有
    }
}
