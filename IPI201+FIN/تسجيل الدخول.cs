using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IPI201_FIN
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_verify_server_Click(object sender, EventArgs e)
        {
            string x = "";
            x = txt_login_server_name.Text;


            try
            {
              string connection_string_new = @"Server =.\" + x + "; Database = master; User Id = sa; Password = 123;";
                SqlConnection Conn = new SqlConnection(connection_string_new);
                Conn.Open();
                MessageBox.Show("ok");


            }
            catch (Exception)
            {
                MessageBox.Show("nooo");

            }

          


        }
        public void caret_data()
        {

            //string createDbQuery = $@"
            //        IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = '{dbName}')
            //        BEGIN
            //            CREATE DATABASE [{dbName}];
            //        END;";


        }
    }
}
