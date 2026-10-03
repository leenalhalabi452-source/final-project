namespace IPI201_FIN
{
    partial class Form2
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lbl_employee_name = new System.Windows.Forms.Label();
            this.lbl_hospital_name = new System.Windows.Forms.Label();
            this.lbl_subtitle = new System.Windows.Forms.Label();
            this.lbl_icon_user = new System.Windows.Forms.Label();
            this.lbl_icon_logo = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_schedule = new System.Windows.Forms.Button();
            this.btn_leave_requests = new System.Windows.Forms.Button();
            this.btn_appointments = new System.Windows.Forms.Button();
            this.btn_view_2 = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_approve_leave = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.panelTop.Controls.Add(this.lbl_subtitle);
            this.panelTop.Controls.Add(this.lbl_hospital_name);
            this.panelTop.Controls.Add(this.lbl_employee_name);
            this.panelTop.Controls.Add(this.lbl_icon_user);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1000, 109);
            this.panelTop.TabIndex = 0;
            // 
            // lbl_employee_name
            // 
            this.lbl_employee_name.AutoSize = true;
            this.lbl_employee_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_employee_name.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_employee_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.lbl_employee_name.Location = new System.Drawing.Point(711, 9);
            this.lbl_employee_name.Name = "lbl_employee_name";
            this.lbl_employee_name.Size = new System.Drawing.Size(244, 50);
            this.lbl_employee_name.TabIndex = 1;
            this.lbl_employee_name.Text = "اسم الموظف :";
            this.lbl_employee_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_hospital_name
            // 
            this.lbl_hospital_name.AutoSize = true;
            this.lbl_hospital_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hospital_name.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_hospital_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lbl_hospital_name.Location = new System.Drawing.Point(116, 0);
            this.lbl_hospital_name.Name = "lbl_hospital_name";
            this.lbl_hospital_name.Size = new System.Drawing.Size(228, 32);
            this.lbl_hospital_name.TabIndex = 2;
            this.lbl_hospital_name.Text = "مجمع العيادات الطبية";
            // 
            // lbl_subtitle
            // 
            this.lbl_subtitle.AutoSize = true;
            this.lbl_subtitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_subtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(220)))));
            this.lbl_subtitle.Location = new System.Drawing.Point(664, 75);
            this.lbl_subtitle.Name = "lbl_subtitle";
            this.lbl_subtitle.Size = new System.Drawing.Size(340, 23);
            this.lbl_subtitle.TabIndex = 3;
            this.lbl_subtitle.Text = "إدارة الموظفين والعيادات والمناوبات والمواعيد";
            // 
            // lbl_icon_user
            // 
            this.lbl_icon_user.AutoSize = true;
            this.lbl_icon_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_icon_user.Font = new System.Drawing.Font("Segoe UI Emoji", 24F);
            this.lbl_icon_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.lbl_icon_user.Location = new System.Drawing.Point(939, 9);
            this.lbl_icon_user.Name = "lbl_icon_user";
            this.lbl_icon_user.Size = new System.Drawing.Size(70, 53);
            this.lbl_icon_user.TabIndex = 4;
            this.lbl_icon_user.Text = "👤";
            // 
            // lbl_icon_logo
            // 
            this.lbl_icon_logo.AutoSize = true;
            this.lbl_icon_logo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_icon_logo.Font = new System.Drawing.Font("Segoe UI Emoji", 30F);
            this.lbl_icon_logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lbl_icon_logo.Location = new System.Drawing.Point(890, 15);
            this.lbl_icon_logo.Name = "lbl_icon_logo";
            this.lbl_icon_logo.Size = new System.Drawing.Size(96, 67);
            this.lbl_icon_logo.TabIndex = 5;
            this.lbl_icon_logo.Text = "🏥";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Location = new System.Drawing.Point(30, 126);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(700, 542);
            this.panelMain.TabIndex = 8;
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.btn_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_view.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btn_view.FlatAppearance.BorderSize = 2;
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_view.ForeColor = System.Drawing.Color.White;
            this.btn_view.Location = new System.Drawing.Point(760, 115);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(200, 50);
            this.btn_view.TabIndex = 11;
            this.btn_view.Text = "👁️ عرض";
            this.btn_view.UseVisualStyleBackColor = false;
            // 
            // btn_schedule
            // 
            this.btn_schedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.btn_schedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_schedule.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btn_schedule.FlatAppearance.BorderSize = 2;
            this.btn_schedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_schedule.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_schedule.ForeColor = System.Drawing.Color.White;
            this.btn_schedule.Location = new System.Drawing.Point(760, 175);
            this.btn_schedule.Name = "btn_schedule";
            this.btn_schedule.Size = new System.Drawing.Size(200, 50);
            this.btn_schedule.TabIndex = 12;
            this.btn_schedule.Text = "📅 جدول";
            this.btn_schedule.UseVisualStyleBackColor = false;
            // 
            // btn_leave_requests
            // 
            this.btn_leave_requests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.btn_leave_requests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_leave_requests.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btn_leave_requests.FlatAppearance.BorderSize = 2;
            this.btn_leave_requests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leave_requests.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_leave_requests.ForeColor = System.Drawing.Color.White;
            this.btn_leave_requests.Location = new System.Drawing.Point(760, 235);
            this.btn_leave_requests.Name = "btn_leave_requests";
            this.btn_leave_requests.Size = new System.Drawing.Size(200, 50);
            this.btn_leave_requests.TabIndex = 13;
            this.btn_leave_requests.Text = "📋 طلبات اجازة";
            this.btn_leave_requests.UseVisualStyleBackColor = false;
            // 
            // btn_appointments
            // 
            this.btn_appointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.btn_appointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_appointments.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btn_appointments.FlatAppearance.BorderSize = 2;
            this.btn_appointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_appointments.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_appointments.ForeColor = System.Drawing.Color.White;
            this.btn_appointments.Location = new System.Drawing.Point(760, 295);
            this.btn_appointments.Name = "btn_appointments";
            this.btn_appointments.Size = new System.Drawing.Size(200, 50);
            this.btn_appointments.TabIndex = 14;
            this.btn_appointments.Text = "🕐 مواعيد";
            this.btn_appointments.UseVisualStyleBackColor = false;
            // 
            // btn_view_2
            // 
            this.btn_view_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.btn_view_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_view_2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btn_view_2.FlatAppearance.BorderSize = 2;
            this.btn_view_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view_2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_view_2.ForeColor = System.Drawing.Color.White;
            this.btn_view_2.Location = new System.Drawing.Point(760, 355);
            this.btn_view_2.Name = "btn_view_2";
            this.btn_view_2.Size = new System.Drawing.Size(200, 50);
            this.btn_view_2.TabIndex = 15;
            this.btn_view_2.Text = "👁️ عرض";
            this.btn_view_2.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(80)))));
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(120)))));
            this.btn_add.FlatAppearance.BorderSize = 2;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(760, 415);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(200, 50);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "➕ إضافة";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btn_edit.FlatAppearance.BorderSize = 2;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(760, 475);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(200, 50);
            this.btn_edit.TabIndex = 17;
            this.btn_edit.Text = "✏️ تعديل";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_delete.FlatAppearance.BorderSize = 2;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(760, 535);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(200, 50);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "🗑️ حذف";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_approve_leave
            // 
            this.btn_approve_leave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btn_approve_leave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_approve_leave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btn_approve_leave.FlatAppearance.BorderSize = 2;
            this.btn_approve_leave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_approve_leave.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_approve_leave.ForeColor = System.Drawing.Color.White;
            this.btn_approve_leave.Location = new System.Drawing.Point(760, 595);
            this.btn_approve_leave.Name = "btn_approve_leave";
            this.btn_approve_leave.Size = new System.Drawing.Size(200, 50);
            this.btn_approve_leave.TabIndex = 19;
            this.btn_approve_leave.Text = "✅ موافقة إجازة";
            this.btn_approve_leave.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.btn_approve_leave);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_view_2);
            this.Controls.Add(this.btn_appointments);
            this.Controls.Add(this.btn_leave_requests);
            this.Controls.Add(this.btn_schedule);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.lbl_icon_logo);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "واجهة المدير";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lbl_employee_name;
        private System.Windows.Forms.Label lbl_hospital_name;
        private System.Windows.Forms.Label lbl_subtitle;
        private System.Windows.Forms.Label lbl_icon_user;
        private System.Windows.Forms.Label lbl_icon_logo;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_schedule;
        private System.Windows.Forms.Button btn_leave_requests;
        private System.Windows.Forms.Button btn_appointments;
        private System.Windows.Forms.Button btn_view_2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_approve_leave;
    }
}