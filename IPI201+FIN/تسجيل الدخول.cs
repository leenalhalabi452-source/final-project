using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IPI201_FIN
{
    public partial class Form1 : Form
    {

        public static string t;

        public static string connection_string_new;
        public string xcccc;
        bool result = true;

        public Form1()
        {
            InitializeComponent();

        }

        public void GetCon()
        {
            xcccc = @"Server =.\" + t + "; Database = HOOSSS; User Id = sa; Password = 123;";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
                        LoginInitializer.DisableLoginFields(
                txt_login_username,
                txt_login_password,
                btn_login_login);

        }

        private void btn_login_verify_server_Click(object sender, EventArgs e)
        {
            if (!LoginInitializer.ValidateInputs(txt_login_server_name))
                return;

            caret_data();
            if (result)
            {
                LoginInitializer.ShowSuccess("تم التحقق من السيرفر وإنشاء قاعدة البيانات بنجاح ✅");

                LoginInitializer.EnableLoginFields(
                    txt_login_username,
                    txt_login_password,
                    btn_login_login);

                LoginInitializer.LockServerField(
                    txt_login_server_name,
                    btn_login_verify_server);
            }
            else
            {
                LoginInitializer.ShowError("فشل الاتصال بالسيرفر أو إنشاء قاعدة البيانات ❌");
            }




        }
        public void caret_data()
        {
            t = txt_login_server_name.Text;


            try
            {
                connection_string_new = @"Server =.\" + t + "; Database = master; User Id = sa; Password = 123;";
                string createDbQuery = $@"
                    IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'HOOSSS')
                    BEGIN
                        CREATE DATABASE [HOOSSS];
                    END;";
                using (SqlConnection conn = new SqlConnection(connection_string_new))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(createDbQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                 xcccc = @"Server =.\" + t + "; Database = HOOSSS; User Id = sa; Password = 123;";
                Create_Tables.ExecuteAllTables(xcccc );
                Create_Procedures.ExecuteAllProcedures (xcccc );     





            }
            catch (Exception)
            {
                result = false;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FirstAdminForm().ShowDialog();

        }

        private void btn_login_login_Click(object sender, EventArgs e)
        {
            if (!LoginInitializer.ValidateInputs(txt_login_username, txt_login_password))
                return;

            GetData gd = new GetData();
            model m = gd.Login(txt_login_username.Text.Trim(), txt_login_password.Text.Trim());

            if (m != null)
            {
                LoginInitializer.ShowSuccess($"مرحباً {m.Name}\nالصلاحية: {m.role}");
                LoginInitializer.OpenFormByRole(m.role, this);
            }
            else
            {
                LoginInitializer.ShowError("اسم المستخدم أو كلمة المرور غير صحيحة، أو الحساب غير نشط");
                LoginInitializer.ClearFields(txt_login_password);
                txt_login_password.Focus();
            }



        }
    }
}
