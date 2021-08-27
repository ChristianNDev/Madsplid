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

namespace Madspild
{
    public partial class Form1 : Form
    {
        string cs = "You're database connection";
        public Form1()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void App_Close_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private void login_btn_Click_1(object sender, EventArgs e)
        {
            if (account_txt.Text == "")
            {
                MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                account_txt.Focus();
                return;
            }
            if (password_txt.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password_txt.Focus();
                return;
            }

            SqlConnection myConnection = default(SqlConnection);
            myConnection = new SqlConnection(cs);

            SqlCommand myCommand = default(SqlCommand);
            //Sql queries
            myCommand = new SqlCommand("SELECT LoginName,FirstName FROM [User] WHERE LoginName = @Username AND FirstName = @Password", myConnection);
            //Tildeler værdien til en variable for at undgå sql injection
            SqlParameter uName = new SqlParameter("@Username", SqlDbType.VarChar);
            SqlParameter uPassword = new SqlParameter("@Password", SqlDbType.VarChar);
            //Tildeler variablerne til tekstbokserne
            uName.Value = account_txt.Text;
            uPassword.Value = password_txt.Text;
            myCommand.Parameters.Add(uName);
            myCommand.Parameters.Add(uPassword);

            myCommand.Connection.Open();

            SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

            if (myReader.Read() == true)
            {
                MessageBox.Show("You have logged in successfully " + account_txt.Text);
                //Skjuler formen
                Form1 frm1 = new Form1();
                main me = new main();
                this.Hide();
                me.ShowDialog();
                this.Close();
                myCommand.Connection.Close();

            }

            else
            {
                MessageBox.Show("Login Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                account_txt.Text = "";
                password_txt.Text = "";

                account_txt.Focus();

            }

        }

        private void account_txt_Click(object sender, EventArgs e)
        {
            account_txt.Text = "";
        }

        private void password_txt_Click(object sender, EventArgs e)
        {
            password_txt.Text = "";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
