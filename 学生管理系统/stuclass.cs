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
    public partial class Form4 : Form
    {
        public string class_id;
        public int num;
        public Form4()
        {
            InitializeComponent();
            Login login = new Login();
            login.Conn1(Login_form.us, Login_form.psw);
            SqlCommand Sqcm = login.conn.CreateCommand();
            //int intID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            //SqlConnection Sqlcon;
            SqlDataAdapter Sqlda = new SqlDataAdapter("Select * from stuclass", login.conn);
            DataSet DS = new DataSet();
            Sqlda.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.Show();
            login.conn.Close();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Selected = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()=="")
                {
                    class_id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    num = e.RowIndex;
                    return;
                }
                class_id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                num = e.RowIndex;
            }
            catch
            {
                //MessageBox.Show("你点他干啥啊？=^_^=");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("查询内容不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Login login = new Login();
            login.Conn1(Login_form.us, Login_form.psw);
            string str;
            if (textBox1.Text.ToString()[0] >= 'A' && textBox1.Text.ToString()[0] <= 'Z')
            {
                 str = "select * from stuclass where 教室ID like '" + textBox1.Text + "%'";
            }
            else
            {
                 str = "select * from stuclass where 教室ID like '_" + textBox1.Text + "%'";
            }
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataAdapter Sqlda = new SqlDataAdapter(str, login.conn);
            DataSet DS = new DataSet();
            Sqlda.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.Show();
            login.conn.Close();
              
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Conn1(Login_form.us, Login_form.psw);
            string str = "select * from stuclass where  状态= '空闲' ";
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataAdapter Sqlda = new SqlDataAdapter(str, login.conn);
            DataSet DS = new DataSet();
            Sqlda.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.Show();
            login.conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Conn1(Login_form.us, Login_form.psw);
            string str = "select *from stuclass where  状态='考试' ";
            SqlDataAdapter sqlData = new SqlDataAdapter(str, login.conn);
            DataSet DS = new DataSet();
            sqlData.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.Show();
            login.conn.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Conn1(Login_form.us, Login_form.psw);
            string str = "select * from stuclass where 状态='上课' ";
            SqlDataAdapter sqlData = new SqlDataAdapter(str, login.conn);
            DataSet DS = new DataSet();
            sqlData.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.Show();
            login.conn.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Conn1(Login_form.us, Login_form.psw);
            SqlCommand Sqcm = login.conn.CreateCommand();
            SqlDataAdapter Sqlda = new SqlDataAdapter("Select * from stuclass", login.conn);
            DataSet DS = new DataSet();
            Sqlda.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.Show();
            login.conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login login= new Login();
            login.Conn1(Login_form.us,Login_form.psw);
            SqlCommand sqlCommand = new SqlCommand("update stuclass set 状态= '" + textBox2.Text + "' where 教室ID= '" + class_id + "'", login.conn);
            if (sqlCommand.ExecuteNonQuery()>0)
            {
                MessageBox.Show("更改成功");
            }
           
            SqlDataAdapter Sqlda = new SqlDataAdapter("Select * from stuclass", login.conn);
            DataSet DS = new DataSet();
            Sqlda.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.Rows[num].Selected = true;
            dataGridView1.Show();
            dataGridView1.Rows[num].Selected = true;
            login.conn.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
