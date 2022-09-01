using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQTesting
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private string ConnectionString;
        private SqlConnection cnn;
        private void b_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionString = @"Data Source=NAMNORMAL\SQLEXPRESS;Initial Catalog=Test;User ID=sa;Password=123456";
                cnn = new SqlConnection(ConnectionString);
                cnn.Open();
                b_Login.Enabled = true;
                b_Connect.Enabled = false;
            }
            catch(Exception)
            {
                MessageBox.Show("Cannot connect to sever! Try Again");
            }

        }
        
        private void b_Login_Click(object sender, EventArgs e)
        {
            if(t_Password.Text != "" && t_UserName.Text != "")
            {
                DataClasses1DataContext db = new DataClasses1DataContext(ConnectionString);
                var User = db.S_Users.SingleOrDefault(x => (x.PassWord.Equals(t_Password.Text) && x.Name.Equals(t_UserName.Text)));
                if(User != null)
                {
                    MessageBox.Show("Login sucess");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong password or username");
                }
            }
            else
            {
                MessageBox.Show("You haven't enterred enough information");
            }
        }

        
    }
}
