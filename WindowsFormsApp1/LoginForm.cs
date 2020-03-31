using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApp1 {
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            performLogin();
        }

        private void performLogin()
        {
            DataTable allUsers = DBManager.performSql("select * from userName");
            int usersCount = allUsers.Rows.Count;
            string enteredUserName = loginTextBox.Text;
            string enteredUserPassword = passTextBox.Text;
            bool finded = false;
            for (int i = 0; i < usersCount; i++)
            {
                int userId = allUsers.Rows[i].Field<int>("id");
                string userName = allUsers.Rows[i].Field<string>("nameUser").ToString();
                int type = allUsers.Rows[i].Field<int>("type");
                string passwordEncrypted = allUsers.Rows[i].Field<string>("Password");
                if (userName.CompareTo(enteredUserName) == 0 &&
                    DBManager.EncryptPassword(enteredUserPassword).CompareTo(passwordEncrypted) == 0)
                {
                    finded = true;
                    break;
                }
            }
            if (finded)
            {
                Program.SwitchMainForm(new MainForm());
            }
            else
            {
                MessageBox.Show("Користувач з таким логіном або паролем не існує");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.SwitchMainForm(new RegisterForm());
        }

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                performLogin();
            }
        }
    }


    public static class DBManager {
        public static string connectionString = "server = 193.93.216.145; CharacterSet = cp1251;" +
                    "user = sqlist18_1_das; database = sqlist18_1_das; password = sqlist18_das;";
        public static string userType { get; set; }
        public static BindingSource bindingSource { get; set; }

        public static string EncryptPassword(string pass) {
            if (string.Compare(pass, "null", true) == 0) {
                return "NULL";
            }

            byte[] bytes = Encoding.Unicode.GetBytes(pass);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] hashByteArr = md5.ComputeHash(bytes);

            string hash = string.Empty;

            foreach (byte byt in hashByteArr) {
                hash += string.Format("{0:x2}", byt);
            }
            return hash;
        }

        public static DataTable performSql(string sqlQuery) {
            DataTable dataTable = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(DBManager.connectionString)) {
                MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                try
                {
                    connection.Open();
                    using (MySqlDataReader dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            dataTable.Load(dataReader);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return dataTable;
        }

    }
}
