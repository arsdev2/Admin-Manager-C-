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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            DBManager.connectionString = "server = 193.93.216.145; CharacterSet = cp1251;" +
                    "user = sqlist18_1_das; database = sqlist18_1_das; password = sqlist18_das;";
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            performRegister();
        }

        private void performRegister()
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
                if (userName.CompareTo(enteredUserName) == 0)
                {
                    finded = true;
                    break;
                }
            }
            if (finded)
            {
                MessageBox.Show("Користувач з таким логіном уже існує");
            }
            else
            {
                String encryptPass = DBManager.EncryptPassword(enteredUserPassword);
                DBManager.performSql("insert into userName (`nameUser`, `type`, `Password`) values('" + enteredUserName
                     + "', 1, '" + encryptPass + "')");
                MessageBox.Show("Успішно зареєстровано!");
                Program.SwitchMainForm(new LoginForm());
            }
        }

        private void RegisterForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                performRegister();
            }
        }
    }
    
}
