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
    public partial class student : Form
    {
        public string student_id;
        public student()
        {
            InitializeComponent();
            Login login = new Login();
            login.Conn1(Login_form.us, Login_form.psw);
            SqlCommand Sqcm = login.conn.CreateCommand();
            //int intID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            //SqlConnection Sqlcon;
            SqlDataAdapter Sqlda = new SqlDataAdapter("Select * from student", login.conn);
            DataSet DS = new DataSet();
            Sqlda.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.Show();
            login.conn.Close();
        }
        private void student_load(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Selected = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//学号

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//名字

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }//班级

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//性别

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }//联系方式

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }//年龄
        private void Select_button(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Conn1(Login_form.us, Login_form.psw);
            string Select_str = "select * from student where 学生姓名 like '%" +
                stuname_text.Text + "%' and 性别 like '%" + stusex_text.Text + 
                "%'and 学号 like '%" + stuid_text.Text + "%' and 年龄 like '%" +
                stuage_text.Text + "%' and 联系方式 like '%" + stucall_text.Text + 
                "%' and 班级 like '%" + stuclass_text.Text + "%'";
            //SqlCommand sqlCommand  = new SqlCommand();
            //MessageBox.Show(Select_str);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Select_str,login.conn);
            DataSet DS = new DataSet();
            sqlDataAdapter.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.Show();
            login.conn.Close();
        }//查询
        private void Delete_button(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否确认删除" + student_id + "的学生信息?", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Login login = new Login();
                login.Conn1(Login_form.us, Login_form.psw);
                string Delete_str = "Delete from  student where 学号=" + student_id;
                SqlCommand sqlCommand = new SqlCommand(Delete_str, login.conn);
                try
                {
                    if (sqlCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("学号" + student_id + "已经被删除");
                        this.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("学号" + student_id + "删除失败请联系管理员");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("删除失败请联系数据库管理员");
                }
                SqlDataAdapter Sqlda = new SqlDataAdapter("Select * from student", login.conn);
                DataSet DS = new DataSet();
                Sqlda.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                dataGridView1.Show();
                login.conn.Close();
                /* sqlCommand.Connection  =  login.conn;
                 sqlCommand.CommandText = Delete_str;*/

            }
        }//删除
        private void Insert_button(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Conn1(Login_form.us, Login_form.psw);
            SqlCommand sqlCommand = new SqlCommand();
            string Insert_sql = "Insert into student values ('" + stuid_text.Text+"' ," + "'" + stuname_text.Text+ "' ," + "'" + stusex_text.Text + "' ," + "'" + stuage_text.Text+ "' ," + "'" + stuclass_text.Text + "' ," + "'" + stucall_text.Text + "' )";
            sqlCommand.CommandText = Insert_sql;
            sqlCommand.Connection = login.conn;
            if(stuid_text.Text=="")
            {
                MessageBox.Show("学号不能为空","注意",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if(stuname_text.Text=="")
            {
                MessageBox.Show("姓名不能为空","注意",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (sqlCommand.ExecuteNonQuery() > 0) MessageBox.Show("增加学生" + stuname_text.Text + "成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show("请确定您将添加的学生是否已经在数据库内","注意",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            SqlDataAdapter Sqlda = new SqlDataAdapter("Select * from student", login.conn);
            DataSet DS = new DataSet();
            Sqlda.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.Show();
            login.conn.Close();
        }//插入
        protected override void OnClosing(CancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否确认关闭？", "关闭", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            e.Cancel = result != DialogResult.Yes;
            base.OnClosing(e);
        }//关闭
        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Visible = false;
            form2.Show();
        }//返回上一级
        /*private void Form3_load(object sender , EventArgs e)
        {
        }*/
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                student_id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {
                //MessageBox.Show("你点他干啥啊？=^_^=");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            stuid_text.Clear();
            stuname_text.Clear();
            stusex_text.Clear();
            stuage_text.Clear();
            stucall_text.Clear();
            stuclass_text.Clear();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            stuid_text.Clear();
            stuname_text.Clear();
            stusex_text.Clear();
            stuage_text.Clear();
            stucall_text.Clear();
            stuclass_text.Clear();
            Login login = new Login();
            login.Conn1(Login_form.us, Login_form.psw);
            SqlDataAdapter Sqlda = new SqlDataAdapter("Select * from student", login.conn);
            DataSet DS = new DataSet();
            Sqlda.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.Show();
            login.conn.Close();
        }

        private void student_Load(object sender, EventArgs e)
        {

        }
    }

}
