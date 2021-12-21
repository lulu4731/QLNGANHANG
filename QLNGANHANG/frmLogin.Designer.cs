
namespace QLNGANHANG
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_CN = new System.Windows.Forms.ComboBox();
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.Color.Lime;
            this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_DangNhap.Location = new System.Drawing.Point(818, 519);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(144, 39);
            this.btn_DangNhap.TabIndex = 0;
            this.btn_DangNhap.Text = "ĐĂNG NHẬP";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.Red;
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(1046, 520);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(115, 39);
            this.btn_Thoat.TabIndex = 1;
            this.btn_Thoat.Text = "THOÁT";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(747, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(747, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(747, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Chi nhánh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(720, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(556, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "ĐĂNG NHẬP HỆ THỐNG QUẢN LÝ NGÂN HÀNG";
            // 
            // cmb_CN
            // 
            this.cmb_CN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CN.FormattingEnabled = true;
            this.cmb_CN.Location = new System.Drawing.Point(922, 190);
            this.cmb_CN.Name = "cmb_CN";
            this.cmb_CN.Size = new System.Drawing.Size(302, 29);
            this.cmb_CN.TabIndex = 6;
            this.cmb_CN.SelectedIndexChanged += new System.EventHandler(this.cmb_CN_SelectedIndexChanged);
            // 
            // txt_TK
            // 
            this.txt_TK.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TK.Location = new System.Drawing.Point(922, 290);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(302, 29);
            this.txt_TK.TabIndex = 7;
            // 
            // txt_MK
            // 
            this.txt_MK.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MK.Location = new System.Drawing.Point(922, 402);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(302, 29);
            this.txt_MK.TabIndex = 8;
            this.txt_MK.UseSystemPasswordChar = true;
            // 
            // frmLogin
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1338, 570);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.txt_TK);
            this.Controls.Add(this.cmb_CN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangNhap);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmLogin";
            this.Text = "ĐĂNG NHẬP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_CN;
        private System.Windows.Forms.TextBox txt_TK;
        private System.Windows.Forms.TextBox txt_MK;
    }
}