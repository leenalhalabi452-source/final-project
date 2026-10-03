namespace IPI201_FIN
{
    partial class Form7
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
            this.lbl_approve_leave_title = new System.Windows.Forms.Label();
            this.lbl_approve_leave_request = new System.Windows.Forms.Label();
            this.cmb_approve_leave_request = new System.Windows.Forms.ComboBox();
            this.btn_approve_leave_yes = new System.Windows.Forms.Button();
            this.btn_approve_leave_no = new System.Windows.Forms.Button();
            this.btn_approve_leave_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_approve_leave_title
            // 
            this.lbl_approve_leave_title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_approve_leave_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lbl_approve_leave_title.Location = new System.Drawing.Point(50, 30);
            this.lbl_approve_leave_title.Name = "lbl_approve_leave_title";
            this.lbl_approve_leave_title.Size = new System.Drawing.Size(400, 50);
            this.lbl_approve_leave_title.TabIndex = 0;
            this.lbl_approve_leave_title.Text = "اختر طلب الإجازة";
            this.lbl_approve_leave_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_approve_leave_request
            // 
            this.lbl_approve_leave_request.AutoSize = true;
            this.lbl_approve_leave_request.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_approve_leave_request.ForeColor = System.Drawing.Color.White;
            this.lbl_approve_leave_request.Location = new System.Drawing.Point(50, 100);
            this.lbl_approve_leave_request.Name = "lbl_approve_leave_request";
            this.lbl_approve_leave_request.Size = new System.Drawing.Size(113, 28);
            this.lbl_approve_leave_request.TabIndex = 1;
            this.lbl_approve_leave_request.Text = "طلب الإجازة:";
            // 
            // cmb_approve_leave_request
            // 
            this.cmb_approve_leave_request.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_approve_leave_request.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmb_approve_leave_request.FormattingEnabled = true;
            this.cmb_approve_leave_request.Location = new System.Drawing.Point(50, 135);
            this.cmb_approve_leave_request.Name = "cmb_approve_leave_request";
            this.cmb_approve_leave_request.Size = new System.Drawing.Size(400, 36);
            this.cmb_approve_leave_request.TabIndex = 2;
            // 
            // btn_approve_leave_yes
            // 
            this.btn_approve_leave_yes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.btn_approve_leave_yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_approve_leave_yes.FlatAppearance.BorderSize = 0;
            this.btn_approve_leave_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_approve_leave_yes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_approve_leave_yes.ForeColor = System.Drawing.Color.White;
            this.btn_approve_leave_yes.Location = new System.Drawing.Point(50, 210);
            this.btn_approve_leave_yes.Name = "btn_approve_leave_yes";
            this.btn_approve_leave_yes.Size = new System.Drawing.Size(120, 50);
            this.btn_approve_leave_yes.TabIndex = 3;
            this.btn_approve_leave_yes.Text = "✅ موافقة";
            this.btn_approve_leave_yes.UseVisualStyleBackColor = false;
            // 
            // btn_approve_leave_no
            // 
            this.btn_approve_leave_no.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_approve_leave_no.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_approve_leave_no.FlatAppearance.BorderSize = 0;
            this.btn_approve_leave_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_approve_leave_no.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_approve_leave_no.ForeColor = System.Drawing.Color.White;
            this.btn_approve_leave_no.Location = new System.Drawing.Point(190, 210);
            this.btn_approve_leave_no.Name = "btn_approve_leave_no";
            this.btn_approve_leave_no.Size = new System.Drawing.Size(120, 50);
            this.btn_approve_leave_no.TabIndex = 4;
            this.btn_approve_leave_no.Text = "❌ رفض";
            this.btn_approve_leave_no.UseVisualStyleBackColor = false;
            // 
            // btn_approve_leave_cancel
            // 
            this.btn_approve_leave_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.btn_approve_leave_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_approve_leave_cancel.FlatAppearance.BorderSize = 0;
            this.btn_approve_leave_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_approve_leave_cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_approve_leave_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_approve_leave_cancel.Location = new System.Drawing.Point(330, 210);
            this.btn_approve_leave_cancel.Name = "btn_approve_leave_cancel";
            this.btn_approve_leave_cancel.Size = new System.Drawing.Size(120, 50);
            this.btn_approve_leave_cancel.TabIndex = 5;
            this.btn_approve_leave_cancel.Text = "إلغاء";
            this.btn_approve_leave_cancel.UseVisualStyleBackColor = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(500, 320);
            this.Controls.Add(this.lbl_approve_leave_title);
            this.Controls.Add(this.lbl_approve_leave_request);
            this.Controls.Add(this.cmb_approve_leave_request);
            this.Controls.Add(this.btn_approve_leave_yes);
            this.Controls.Add(this.btn_approve_leave_no);
            this.Controls.Add(this.btn_approve_leave_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الموافقة على طلب إجازة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_approve_leave_title;
        private System.Windows.Forms.Label lbl_approve_leave_request;
        private System.Windows.Forms.ComboBox cmb_approve_leave_request;
        private System.Windows.Forms.Button btn_approve_leave_yes;
        private System.Windows.Forms.Button btn_approve_leave_no;
        private System.Windows.Forms.Button btn_approve_leave_cancel;
    }
}