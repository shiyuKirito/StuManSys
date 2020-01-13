using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Login
    {
        public string Userid;
        public string Password;
        public SqlConnection conn = new SqlConnection();
        public void Conn1(string userid, string password)
        {
            this.Userid = userid;
            this.Password = password;
            string  ConnectionString  = "User ID="+userid+";Password="+password+
                ";Initial Catalog=School;Data Source=DESKTOP-P9BAT5G\\SQL_SERVER_SHIYU";
            this.conn = new SqlConnection(ConnectionString);
            conn.Open();
        }
    }
}
