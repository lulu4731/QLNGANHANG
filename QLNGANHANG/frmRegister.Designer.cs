
namespace QLNGANHANG
{
    partial class frmRegister
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
            this.bnt_DangKi = new System.Windows.Forms.Button();
            this.bnt_Thoat = new System.Windows.Forms.Button();
            this.txt_MKDK = new System.Windows.Forms.TextBox();
            this.txt_NLMK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TKDK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_TT = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bnt_DangKi
            // 
            this.bnt_DangKi.BackColor = System.Drawing.Color.Lime;
            this.bnt_DangKi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_DangKi.Location = new System.Drawing.Point(786, 606);
            this.bnt_DangKi.Margin = new System.Windows.Forms.Padding(5);
            this.bnt_DangKi.Name = "bnt_DangKi";
            this.bnt_DangKi.Size = new System.Drawing.Size(125, 37);
            this.bnt_DangKi.TabIndex = 0;
            this.bnt_DangKi.Text = "ĐĂNG KÍ";
            this.bnt_DangKi.UseVisualStyleBackColor = false;
            this.bnt_DangKi.Click += new System.EventHandler(this.bnt_DangKi_Click);
            // 
            // bnt_Thoat
            // 
            this.bnt_Thoat.BackColor = System.Drawing.Color.Red;
            this.bnt_Thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Thoat.Location = new System.Drawing.Point(1019, 606);
            this.bnt_Thoat.Margin = new System.Windows.Forms.Padding(5);
            this.bnt_Thoat.Name = "bnt_Thoat";
            this.bnt_Thoat.Size = new System.Drawing.Size(125, 37);
            this.bnt_Thoat.TabIndex = 1;
            this.bnt_Thoat.Text = "THOÁT";
            this.bnt_Thoat.UseVisualStyleBackColor = false;
            this.bnt_Thoat.Click += new System.EventHandler(this.bnt_Thoat_Click);
            // 
            // txt_MKDK
            // 
            this.txt_MKDK.Location = new System.Drawing.Point(851, 398);
            this.txt_MKDK.Margin = new System.Windows.Forms.Padding(5);
            this.txt_MKDK.Name = "txt_MKDK";
            this.txt_MKDK.Size = new System.Drawing.Size(419, 29);
            this.txt_MKDK.TabIndex = 2;
            this.txt_MKDK.UseSystemPasswordChar = true;
            // 
            // txt_NLMK
            // 
            this.txt_NLMK.Location = new System.Drawing.Point(851, 502);
            this.txt_NLMK.Margin = new System.Windows.Forms.Padding(5);
            this.txt_NLMK.Name = "txt_NLMK";
            this.txt_NLMK.Size = new System.Drawing.Size(419, 29);
            this.txt_NLMK.TabIndex = 3;
            this.txt_NLMK.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(668, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(667, 406);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhập mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(668, 510);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // txt_TKDK
            // 
            this.txt_TKDK.Location = new System.Drawing.Point(851, 209);
            this.txt_TKDK.Margin = new System.Windows.Forms.Padding(5);
            this.txt_TKDK.Name = "txt_TKDK";
            this.txt_TKDK.Size = new System.Drawing.Size(419, 29);
            this.txt_TKDK.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(729, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(474, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "TẠO TÀI KHOẢN QUẢN LÝ NGÂN HÀNG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(668, 313);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tên tài khoản";
            // 
            // cmb_TT
            // 
            this.cmb_TT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TT.FormattingEnabled = true;
            this.cmb_TT.Location = new System.Drawing.Point(851, 311);
            this.cmb_TT.Name = "cmb_TT";
            this.cmb_TT.Size = new System.Drawing.Size(419, 29);
            this.cmb_TT.TabIndex = 13;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1353, 1002);
            this.Controls.Add(this.cmb_TT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TKDK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NLMK);
            this.Controls.Add(this.txt_MKDK);
            this.Controls.Add(this.bnt_Thoat);
            this.Controls.Add(this.bnt_DangKi);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmRegister";
            this.Text = "ĐĂNG KÍ";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_DangKi;
        private System.Windows.Forms.Button bnt_Thoat;
        private System.Windows.Forms.TextBox txt_MKDK;
        private System.Windows.Forms.TextBox txt_NLMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TKDK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_TT;
    }
}