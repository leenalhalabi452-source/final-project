namespace IPI201_FIN
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnl_login_card = new System.Windows.Forms.Panel();
            this.lbl_login_title = new System.Windows.Forms.Label();
            this.lbl_login_server_name = new System.Windows.Forms.Label();
            this.txt_login_server_name = new System.Windows.Forms.TextBox();
            this.btn_login_verify_server = new System.Windows.Forms.Button();
            this.lbl_login_username = new System.Windows.Forms.Label();
            this.txt_login_username = new System.Windows.Forms.TextBox();
            this.lbl_login_password = new System.Windows.Forms.Label();
            this.txt_login_password = new System.Windows.Forms.TextBox();
            this.btn_login_login = new System.Windows.Forms.Button();

            // ===== الأيقونات الزخرفية =====
            this.lbl_login_icon_key = new System.Windows.Forms.Label();
            this.lbl_login_icon_shield_lock = new System.Windows.Forms.Label();
            this.lbl_login_icon_shield_check = new System.Windows.Forms.Label();
            this.lbl_login_icon_user = new System.Windows.Forms.Label();

            this.pnl_login_card.SuspendLayout();
            this.SuspendLayout();

            // ================= Form1 =================
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(155, 125, 210);
            this.ClientSize = new System.Drawing.Size(895, 560);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.Load += new System.EventHandler(this.Form1_Load);

            // ================= pnl_login_card (البطاقة البيضاء) =================
            this.pnl_login_card.BackColor = System.Drawing.Color.White;
            this.pnl_login_card.Location = new System.Drawing.Point(280, 60);
            this.pnl_login_card.Name = "pnl_login_card";
            this.pnl_login_card.Size = new System.Drawing.Size(340, 440);
            this.pnl_login_card.TabIndex = 0;

            // ================= lbl_login_title (LOGIN) =================
            this.lbl_login_title.AutoSize = false;
            this.lbl_login_title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_login_title.ForeColor = System.Drawing.Color.FromArgb(60, 50, 90);
            this.lbl_login_title.Location = new System.Drawing.Point(20, 30);
            this.lbl_login_title.Name = "lbl_login_title";
            this.lbl_login_title.Size = new System.Drawing.Size(300, 40);
            this.lbl_login_title.TabIndex = 1;
            this.lbl_login_title.Text = "LOGIN";
            this.lbl_login_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ================= lbl_login_server_name =================
            this.lbl_login_server_name.AutoSize = true;
            this.lbl_login_server_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_login_server_name.ForeColor = System.Drawing.Color.FromArgb(120, 110, 140);
            this.lbl_login_server_name.Location = new System.Drawing.Point(25, 90);
            this.lbl_login_server_name.Name = "lbl_login_server_name";
            this.lbl_login_server_name.Size = new System.Drawing.Size(90, 20);
            this.lbl_login_server_name.TabIndex = 2;
            this.lbl_login_server_name.Text = "Server Name";

            // ================= txt_login_server_name =================
            this.txt_login_server_name.BackColor = System.Drawing.Color.FromArgb(245, 243, 250);
            this.txt_login_server_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_login_server_name.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_login_server_name.ForeColor = System.Drawing.Color.FromArgb(60, 50, 90);
            this.txt_login_server_name.Location = new System.Drawing.Point(25, 115);
            this.txt_login_server_name.Name = "txt_login_server_name";
            this.txt_login_server_name.Size = new System.Drawing.Size(290, 32);
            this.txt_login_server_name.TabIndex = 3;

            // ================= btn_login_verify_server (DONE) =================
            this.btn_login_verify_server.BackColor = System.Drawing.Color.FromArgb(155, 125, 210);
            this.btn_login_verify_server.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login_verify_server.FlatAppearance.BorderSize = 0;
            this.btn_login_verify_server.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(175, 145, 230);
            this.btn_login_verify_server.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(135, 105, 190);
            this.btn_login_verify_server.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_login_verify_server.ForeColor = System.Drawing.Color.White;
            this.btn_login_verify_server.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login_verify_server.Location = new System.Drawing.Point(25, 155);
            this.btn_login_verify_server.Name = "btn_login_verify_server";
            this.btn_login_verify_server.Size = new System.Drawing.Size(290, 35);
            this.btn_login_verify_server.TabIndex = 4;
            this.btn_login_verify_server.Text = "DONE ✔";
            this.btn_login_verify_server.UseVisualStyleBackColor = false;

            // ================= lbl_login_username =================
            this.lbl_login_username.AutoSize = true;
            this.lbl_login_username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_login_username.ForeColor = System.Drawing.Color.FromArgb(120, 110, 140);
            this.lbl_login_username.Location = new System.Drawing.Point(25, 210);
            this.lbl_login_username.Name = "lbl_login_username";
            this.lbl_login_username.Size = new System.Drawing.Size(80, 20);
            this.lbl_login_username.TabIndex = 5;
            this.lbl_login_username.Text = "Username";

            // ================= txt_login_username =================
            this.txt_login_username.BackColor = System.Drawing.Color.FromArgb(245, 243, 250);
            this.txt_login_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_login_username.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_login_username.ForeColor = System.Drawing.Color.FromArgb(60, 50, 90);
            this.txt_login_username.Location = new System.Drawing.Point(25, 235);
            this.txt_login_username.Name = "txt_login_username";
            this.txt_login_username.Size = new System.Drawing.Size(290, 32);
            this.txt_login_username.TabIndex = 6;

            // ================= lbl_login_password =================
            this.lbl_login_password.AutoSize = true;
            this.lbl_login_password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_login_password.ForeColor = System.Drawing.Color.FromArgb(120, 110, 140);
            this.lbl_login_password.Location = new System.Drawing.Point(25, 285);
            this.lbl_login_password.Name = "lbl_login_password";
            this.lbl_login_password.Size = new System.Drawing.Size(75, 20);
            this.lbl_login_password.TabIndex = 7;
            this.lbl_login_password.Text = "Password";

            // ================= txt_login_password =================
            this.txt_login_password.BackColor = System.Drawing.Color.FromArgb(245, 243, 250);
            this.txt_login_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_login_password.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_login_password.ForeColor = System.Drawing.Color.FromArgb(60, 50, 90);
            this.txt_login_password.Location = new System.Drawing.Point(25, 310);
            this.txt_login_password.Name = "txt_login_password";
            this.txt_login_password.Size = new System.Drawing.Size(290, 32);
            this.txt_login_password.TabIndex = 8;
            this.txt_login_password.UseSystemPasswordChar = true;

            // ================= btn_login_login (LOG IN) =================
            this.btn_login_login.BackColor = System.Drawing.Color.FromArgb(110, 80, 180);
            this.btn_login_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login_login.FlatAppearance.BorderSize = 0;
            this.btn_login_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(130, 100, 200);
            this.btn_login_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(90, 65, 150);
            this.btn_login_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_login_login.ForeColor = System.Drawing.Color.White;
            this.btn_login_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login_login.Location = new System.Drawing.Point(25, 365);
            this.btn_login_login.Name = "btn_login_login";
            this.btn_login_login.Size = new System.Drawing.Size(290, 45);
            this.btn_login_login.TabIndex = 9;
            this.btn_login_login.Text = "Log In";
            this.btn_login_login.UseVisualStyleBackColor = false;

            // ================= إضافة العناصر للبطاقة =================
            this.pnl_login_card.Controls.Add(this.btn_login_login);
            this.pnl_login_card.Controls.Add(this.txt_login_password);
            this.pnl_login_card.Controls.Add(this.lbl_login_password);
            this.pnl_login_card.Controls.Add(this.txt_login_username);
            this.pnl_login_card.Controls.Add(this.lbl_login_username);
            this.pnl_login_card.Controls.Add(this.btn_login_verify_server);
            this.pnl_login_card.Controls.Add(this.txt_login_server_name);
            this.pnl_login_card.Controls.Add(this.lbl_login_server_name);
            this.pnl_login_card.Controls.Add(this.lbl_login_title);

            // ================= 🔑 الأيقونة 1: مفتاح (فوق يسار) =================
            this.lbl_login_icon_key.AutoSize = false;
            this.lbl_login_icon_key.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login_icon_key.Font = new System.Drawing.Font("Segoe UI Emoji", 45F);
            this.lbl_login_icon_key.ForeColor = System.Drawing.Color.FromArgb(200, 255, 255, 255);
            this.lbl_login_icon_key.Location = new System.Drawing.Point(80, 130);
            this.lbl_login_icon_key.Name = "lbl_login_icon_key";
            this.lbl_login_icon_key.Size = new System.Drawing.Size(100, 100);
            this.lbl_login_icon_key.TabIndex = 10;
            this.lbl_login_icon_key.Text = "🔑";
            this.lbl_login_icon_key.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ================= 🔒 الأيقونة 2: درع/قفل (فوق يمين) =================
            this.lbl_login_icon_shield_lock.AutoSize = false;
            this.lbl_login_icon_shield_lock.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login_icon_shield_lock.Font = new System.Drawing.Font("Segoe UI Emoji", 45F);
            this.lbl_login_icon_shield_lock.ForeColor = System.Drawing.Color.FromArgb(200, 255, 255, 255);
            this.lbl_login_icon_shield_lock.Location = new System.Drawing.Point(715, 130);
            this.lbl_login_icon_shield_lock.Name = "lbl_login_icon_shield_lock";
            this.lbl_login_icon_shield_lock.Size = new System.Drawing.Size(100, 100);
            this.lbl_login_icon_shield_lock.TabIndex = 11;
            this.lbl_login_icon_shield_lock.Text = "🛡";
            this.lbl_login_icon_shield_lock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ================= ✔️ الأيقونة 3: درع مع صح (تحت يسار) =================
            this.lbl_login_icon_shield_check.AutoSize = false;
            this.lbl_login_icon_shield_check.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login_icon_shield_check.Font = new System.Drawing.Font("Segoe UI Emoji", 45F);
            this.lbl_login_icon_shield_check.ForeColor = System.Drawing.Color.FromArgb(200, 255, 255, 255);
            this.lbl_login_icon_shield_check.Location = new System.Drawing.Point(80, 400);
            this.lbl_login_icon_shield_check.Name = "lbl_login_icon_shield_check";
            this.lbl_login_icon_shield_check.Size = new System.Drawing.Size(100, 100);
            this.lbl_login_icon_shield_check.TabIndex = 12;
            this.lbl_login_icon_shield_check.Text = "✅";
            this.lbl_login_icon_shield_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ================= 👤 الأيقونة 4: شخص (تحت يمين) =================
            this.lbl_login_icon_user.AutoSize = false;
            this.lbl_login_icon_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login_icon_user.Font = new System.Drawing.Font("Segoe UI Emoji", 45F);
            this.lbl_login_icon_user.ForeColor = System.Drawing.Color.FromArgb(200, 255, 255, 255);
            this.lbl_login_icon_user.Location = new System.Drawing.Point(715, 400);
            this.lbl_login_icon_user.Name = "lbl_login_icon_user";
            this.lbl_login_icon_user.Size = new System.Drawing.Size(100, 100);
            this.lbl_login_icon_user.TabIndex = 13;
            this.lbl_login_icon_user.Text = "👤";
            this.lbl_login_icon_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ================= إضافة العناصر للفورم =================
            this.Controls.Add(this.lbl_login_icon_key);
            this.Controls.Add(this.lbl_login_icon_shield_lock);
            this.Controls.Add(this.lbl_login_icon_shield_check);
            this.Controls.Add(this.lbl_login_icon_user);
            this.Controls.Add(this.pnl_login_card);

            this.pnl_login_card.ResumeLayout(false);
            this.pnl_login_card.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_login_card;
        private System.Windows.Forms.TextBox txt_login_server_name;
        private System.Windows.Forms.Button btn_login_verify_server;
        private System.Windows.Forms.Label lbl_login_title;
        private System.Windows.Forms.Label lbl_login_server_name;
        private System.Windows.Forms.Label lbl_login_username;
        private System.Windows.Forms.Label lbl_login_password;
        private System.Windows.Forms.Button btn_login_login;
        private System.Windows.Forms.TextBox txt_login_password;
        private System.Windows.Forms.TextBox txt_login_username;

        // ===== الأيقونات الزخرفية =====
        private System.Windows.Forms.Label lbl_login_icon_key;
        private System.Windows.Forms.Label lbl_login_icon_shield_lock;
        private System.Windows.Forms.Label lbl_login_icon_shield_check;
        private System.Windows.Forms.Label lbl_login_icon_user;
    }
}