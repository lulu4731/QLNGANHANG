
namespace QLNGANHANG
{
    partial class frmChuyenChiNhanh
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_maNVNew = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Chuyen = new System.Windows.Forms.Button();
            this.cmb_CN = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã nhân viên mới:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_maNVNew
            // 
            this.txt_maNVNew.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maNVNew.Location = new System.Drawing.Point(338, 223);
            this.txt_maNVNew.Name = "txt_maNVNew";
            this.txt_maNVNew.Size = new System.Drawing.Size(317, 29);
            this.txt_maNVNew.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "CHUYỂN CHI NHÁNH NHÂN VIÊN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chọn chi nhánh";
            // 
            // btn_Chuyen
            // 
            this.btn_Chuyen.BackColor = System.Drawing.Color.Lime;
            this.btn_Chuyen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Chuyen.Location = new System.Drawing.Point(258, 347);
            this.btn_Chuyen.Name = "btn_Chuyen";
            this.btn_Chuyen.Size = new System.Drawing.Size(242, 40);
            this.btn_Chuyen.TabIndex = 4;
            this.btn_Chuyen.Text = "CHUYỂN NHÂN VIÊN";
            this.btn_Chuyen.UseVisualStyleBackColor = false;
            this.btn_Chuyen.Click += new System.EventHandler(this.btn_Chuyen_Click);
            // 
            // cmb_CN
            // 
            this.cmb_CN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CN.FormattingEnabled = true;
            this.cmb_CN.Location = new System.Drawing.Point(338, 135);
            this.cmb_CN.Name = "cmb_CN";
            this.cmb_CN.Size = new System.Drawing.Size(317, 29);
            this.cmb_CN.TabIndex = 5;
            // 
            // frmChuyenChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_CN);
            this.Controls.Add(this.btn_Chuyen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_maNVNew);
            this.Controls.Add(this.label1);
            this.Name = "frmChuyenChiNhanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHUYỂN CHI NHÁNH";
            this.Load += new System.EventHandler(this.frmChuyenChiNhanh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_maNVNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Chuyen;
        private System.Windows.Forms.ComboBox cmb_CN;
    }
}